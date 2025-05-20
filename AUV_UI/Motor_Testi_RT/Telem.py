import time
import os
import threading
import serial
TxDataUART = b""
Buff=""
durmasarti = True
RxDataNet = "None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None, None"
TxData = ""
sicaklik = 0
TxMotorVerisi = [125]*8
TxSpwm = [100]*8

MotorVerisi = [125]*8
Spwm = [125]*8
hareket = None
hiz = None

ser = serial.Serial(
        port='/dev/ttyS0',
        baudrate = 115200,
        parity=serial.PARITY_NONE,
        stopbits=serial.STOPBITS_ONE,
        bytesize=serial.EIGHTBITS,
        timeout=1000
)

def ConsolePrint():
        global RxDataNet, durmasarti, TxMotorVerisi, TxSpwm
        while durmasarti:
                if RxDataNet != "":
                    print(str(sicaklik) + ',' + RxDataNet)
                    time.sleep(0.01)
                    #os.system('clear')

def UartWrite():
    global durmasarti, TxData, TxDataUART
    while durmasarti:
        TxDataUART = TxData
        if isinstance(TxDataUART, str):
            ser.write(bytearray(TxDataUART, 'utf-8'))
        else:
            ser.write(bytearray(TxDataUART))
        time.sleep(0.01)

def UartRead():
    global RxDataNet, durmasarti
    while durmasarti:
        if ser.in_waiting > 0:
            if ser.read(1).decode('utf-8') == '@':
                RxData = ""
                while True:
                    Buff = ser.read(1).decode('utf-8')
                    if Buff == "#":
                        RxDataNet = RxData
                        break
                    RxData += Buff
        time.sleep(0.01)

def MotorDegerUpdate():
        global durmasarti
        global MotorVerisi
        global TxMotorVerisi
        global TxSpwm
        global Spwm
        while durmasarti:
                for i in range(0,len(MotorVerisi)):
                        if MotorVerisi[i] > TxMotorVerisi[i]:
                                TxMotorVerisi[i] = TxMotorVerisi[i] + 1
                        elif MotorVerisi[i] == TxMotorVerisi[i]:
                                pass
                        elif MotorVerisi[i] < TxMotorVerisi[i]:
                                TxMotorVerisi[i] = TxMotorVerisi[i] - 1
                for i in range(0,len(Spwm)):
                        if Spwm[i] > TxSpwm[i]:
                                TxSpwm[i] = TxSpwm[i] + 1
                        elif Spwm[i] == TxSpwm[i]:
                                pass
                        elif Spwm[i] < TxSpwm[i]:
                                TxSpwm[i] = TxSpwm[i] - 1
                time.sleep(0.005)

def ConfYukleme():
        with open("Motor_Conf.txt", "r", encoding="utf-8") as file:
                for line in file:
                        line = line.strip()
                        #print(line)
                        if line != '':
                                ser.write(bytearray("@*" + line + "\n", 'utf-8'))
                                time.sleep(0.1)
        #ser.write(b"@*we" + b"##################") #motor eeprom write
        #ser.write(b"@*em" + b"##################") #mpu eeprom read

def MotorValueUpdate():
        global durmasarti
        global MotorVerisi, TxMotorVerisi
        global TxSpwm
        global Spwm
        while True:
                sayilar = [int(veri) for veri in open("TestMotorSayisalRT.txt", "r").read().split(',') if veri.isdigit()]
                Spwm = sayilar[-8:]
                MotorVerisi = sayilar[:8]
                time.sleep(0.01)

def OtoKomutYon(yon, hiz):
        global TxData
        TxData = "@+" + 'J' + '0' + "----------------" + "#"
        time.sleep(0.01)
        TxData = "@?" + yon + str(hiz) + "----------------" + "#"


def ManuelKomutYon():
        global TxMotorVerisi,TxSpwm,TxData
        while durmasarti:
            TxData = b"@-" + bytes(TxMotorVerisi) + bytes(TxSpwm) + b"####"
            time.sleep(0.05)


def sicaklik_oku_sys():
        global durmasarti, sicaklik
        while durmasarti:
            try:
                with open("/sys/class/thermal/thermal_zone0/temp", "r") as file:
                    sicaklik = int(int(file.read().strip()) / 10.0)
                    time.sleep(0.01)
            except FileNotFoundError:
                print("Sicaklik dosyasi bulunamadi")

if __name__ == '__main__':
        durmasarti = True
        os.chdir("/home/pi/Desktop")
        ConfYukleme()
        ts = threading.Thread(target = sicaklik_oku_sys)
        t0 = threading.Thread(target = MotorValueUpdate)
        t1 = threading.Thread(target = MotorDegerUpdate)
        t5 = threading.Thread(target = ManuelKomutYon)
        t2 = threading.Thread(target = ConsolePrint)
        t3 = threading.Thread(target = UartWrite)
        t4 = threading.Thread(target = UartRead)
        ts.start()
        t0.start()
        t1.start()
        t2.start()
        t3.start()
        t4.start()
        t5.start()
        ts.join()
        t0.join()
        t1.join()
        t2.join()
        t3.join()
        t4.join()
        t5.join()
