using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUV_UI
{
    public partial class MotorConfigurationForm : Form
    {
        public AnaForm Ana;

        public ComboBox[] ComboBoxlerMotor;
        public ComboBox[] ComboBoxlerYon;
        public Label[] harfler, labelyazilar;
        string duzyazi = "";
        public string[] bellek = new string[11];
        public string[] motorYon = new string[10] { "", "", "", "", "", "", "", "", "", "" };
        public string[] motorKonum = new string[8];

        public MotorConfigurationForm(AnaForm ana)
        {
            InitializeComponent();

            ComboBoxlerMotor = new ComboBox[] { comboBox_Yon_M1, comboBox_Yon_M2, comboBox_Yon_M3, comboBox_Yon_M4, comboBox_Yon_M5, comboBox_Yon_M6, comboBox_Yon_M7, comboBox_Yon_M8};
            ComboBoxlerYon = new ComboBox[] { Motor1, Motor2, Motor3, Motor4, Motor5, Motor6, Motor7, Motor8};
            harfler = new Label[] {labelA, labelB, labelC, labelD, labelE, labelF, labelG, labelH, labelI, labelJ};

            Ana = ana;
            for (int j = 0; j < ComboBoxlerMotor.Length; j++) { ComboBoxlerMotor[j].Enabled = false; }
            for (int i = 0; i < ComboBoxlerMotor.Length; i++) { ComboBoxlerMotor[i].SelectedIndex = 0; }
            for (int i = 0; i < ComboBoxlerYon.Length; i++) { ComboBoxlerYon[i].SelectedIndex = 0; }
            for (int i = 0; i < ComboBoxlerYon.Length; i++){ComboBoxlerYon[i].Visible = false;}
            for (int i = 0; i < ComboBoxlerYon.Length; i++) { ComboBoxlerYon[i].SelectedIndexChanged += new System.EventHandler(this.MotorKonumSelected); }
            for (int i = 0; i < harfler.Length; i++) { harfler[i].ForeColor = Color.Red; }
            for (int i = 0; i < ComboBoxlerYon.Length; i++) { ComboBoxlerYon[i].SelectedIndexChanged += new System.EventHandler(this.MotorYonSelected); }
            comboBox_Test_Motoru.SelectedIndex = 0;
            comboBox_Hareket_Tanimla.SelectedIndex = 9;
            Motor_Konum_Kaydet.Enabled = false;

            MotorDuzeni.SelectedIndex = 0;

            if (Ana.Baglanti == true) { Test_Buton.Enabled = true;}
            else { Test_Buton.Enabled = false; Log_Gonder.Enabled = false; }

        }

        private void Test_Buton_Click(object sender, EventArgs e)
        {
            /*
            Test_Buton.Enabled = false;
            byte[] fileData = Properties.Resources.Test_Gonder;

            using (MemoryStream memoryStream = new MemoryStream(fileData))
            {
                try
                {
                    Ana.RaspiSFTPClient.UploadFile(memoryStream, Ana.raspi_dosya_yolu_Gonder + "/Test_Gonder.py");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dosya gönderilemedi: {ex.Message}");
                    Test_Buton.Enabled = true;
                }
            }

            try
            {
                fileData = Properties.Resources.TestMotor;
                string tempFilePath = Path.GetTempFileName();
                File.WriteAllBytes(tempFilePath, fileData);
                string textToAdd = "GelenDeger = [" + MotorDeger(comboBox_Test_Motoru.SelectedIndex) + "]";
                File.WriteAllText(tempFilePath, textToAdd, Encoding.UTF8);
                using (FileStream fs = new FileStream(tempFilePath, FileMode.Open))
                {
                    Ana.RaspiSFTPClient.UploadFile(fs, Ana.raspi_dosya_yolu_Gonder + "/TestMotor.py");
                }
                File.Delete(tempFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya gönderilemedi: {ex.Message}");
                Test_Buton.Enabled = true;
            }
            */
            try
            {
                Ana.shellStream.WriteLine("python " + Ana.raspi_dosya_yolu_Gonder + "/Test_Gonder.py");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                Test_Buton.Enabled = true;
            }
        }

        string MotorDeger(int a)
        {
            switch (a)
            {
                case 0:
                    return "125,125,125,125,125,125,125,125";
                case 1:
                    return "225,125,125,125,125,125,125,125";
                case 2:
                    return "125,225,125,125,125,125,125,125";
                case 3:
                    return "125,125,225,125,125,125,125,125";
                case 4:
                    return "125,125,125,225,125,125,125,125";
                case 5:
                    return "125,125,125,125,225,125,125,125";
                case 6:
                    return "125,125,125,125,125,225,125,125";
                case 7:
                    return "125,125,125,125,125,125,225,125";
                case 8:
                    return "125,125,125,125,125,125,225,125";
                default:
                    return "125,125,125,125,125,125,125,225";
            }
        }

        private void Yon_Hareket_Kaydet_Click(object sender, EventArgs e)
        {
            string a = "";
            for (int i = 0; i < ComboBoxlerMotor.Length; i++)
            {
                a = a + "%" + ComboBoxlerMotor[i].SelectedIndex;
            }
            string b = comboBox_Hareket_Tanimla.GetItemText(comboBox_Hareket_Tanimla.SelectedItem)[1].ToString();
            a = b + a + "%" + b;
            harfler[comboBox_Hareket_Tanimla.SelectedIndex].ForeColor = Color.Green;
            motorYon[comboBox_Hareket_Tanimla.SelectedIndex] = a;
        }

        private void Buton_Kaydi_Sil_Click(object sender, EventArgs e)
        {
            motorYon[comboBox_Hareket_Tanimla.SelectedIndex] = "";
            harfler[comboBox_Hareket_Tanimla.SelectedIndex].ForeColor = Color.Red;
        }

        private void Motor_Konum_Kaydet_Click(object sender, EventArgs e)
        {
            if (MotorDuzeni.SelectedIndex == 1)
            {
                for (int i = 0; i < ComboBoxlerYon.Length-2; i++)
                {
                    if (ComboBoxlerYon[i].SelectedIndex != 0)
                    {
                        int indis = Convert.ToInt32(ComboBoxlerYon[i].GetItemText(ComboBoxlerYon[i].SelectedItem)[1]) - 48 - 1;
                        motorKonum[indis] = ComboBoxlerYon[i].Tag.ToString();
                        for (int j = 0; j < ComboBoxlerMotor.Length; j++) { ComboBoxlerMotor[j].Enabled = true; }
                        pictureBox8.Image = Properties.Resources.greentick;

                        comboBox_Hareket_Tanimla.Enabled = true;
                        Buton_Kaydi_Sil.Enabled = true;
                        motorKonum[7] = "0";
                        motorKonum[6] = "0";
                        Yon_Hareket_Kaydet.Enabled=true;
                    }
                    else
                    {
                        MessageBox.Show("Boşta motor var. Motor yönlerini tekrardan gözden geçirin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Array.Clear(motorKonum, 0, motorKonum.Length);
                        for (int j = 0; j < ComboBoxlerMotor.Length; j++) { ComboBoxlerMotor[j].Enabled = false; }
                        pictureBox8.Image = Properties.Resources.rederror;
                        Yon_Hareket_Kaydet.Enabled = false;
                        LogKaydet.Enabled = false;
                        Log_Gonder.Enabled = false;
                        break;                        
                    }
                }
                
            }

            if (MotorDuzeni.SelectedIndex == 2)
            {
                for (int i = 0; i < ComboBoxlerYon.Length; i++)
                {
                    if (ComboBoxlerYon[i].SelectedIndex != 0)
                    {
                        int indis = Convert.ToInt32(ComboBoxlerYon[i].GetItemText(ComboBoxlerYon[i].SelectedItem)[1]) - 48 - 1;
                        motorKonum[indis] = ComboBoxlerYon[i].Tag.ToString();
                        for (int j = 0; j < ComboBoxlerMotor.Length; j++) { ComboBoxlerMotor[j].Enabled = true; }
                        pictureBox8.Image = Properties.Resources.greentick;
                        comboBox_Hareket_Tanimla.Enabled = true;
                        Yon_Hareket_Kaydet.Enabled = true;
                        Buton_Kaydi_Sil.Enabled = true;
                        Yon_Hareket_Kaydet.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Boşta motor var. Motor yönlerini tekrardan gözden geçirin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Array.Clear(motorKonum, 0, motorKonum.Length);
                        for (int j = 0; j < ComboBoxlerMotor.Length; j++) { ComboBoxlerMotor[j].Enabled = false; }
                        pictureBox8.Image = Properties.Resources.rederror;
                        Yon_Hareket_Kaydet.Enabled = false;
                        break;
                    }
                }
            }

        }

        private void Log_Gonder_Click(object sender, EventArgs e)
        {
            try
            {
                string Gonderilecek = AppDomain.CurrentDomain.BaseDirectory + "Motor_Conf.txt";
                FileStream fs = new FileStream(Gonderilecek, FileMode.Open);
                Ana.RaspiSFTPClient.ChangeDirectory(Ana.raspi_dosya_yolu_Gonder);
                Ana.RaspiSFTPClient.UploadFile(fs, Path.GetFileName(Gonderilecek));
                Ana.terminal.Text += Gonderilecek + " dosyası;" + Environment.NewLine + Ana.raspi_dosya_yolu_Gonder + " adresine yüklendi" + Environment.NewLine;
                MessageBox.Show("Dosya Gonderildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void Log_Goster_Click(object sender, EventArgs e)
        {
            string ilksatir = "";
            for (int i = 0; i < motorKonum.Length; i++)
            {
                ilksatir = ilksatir + "&" + motorKonum[i];
            }
            ilksatir = "!" + ilksatir + "&" + "!";
            bellek[0] = ilksatir;
            for (int i = 1; i < bellek.Length; i++)
            {
                bellek[i] = motorYon[i - 1];
            }
            duzyazi = "";
            for (int i = 0; i < bellek.Length; i++)
            {
                duzyazi = duzyazi + bellek[i] + Environment.NewLine;
            }
            LogWiever gosterici = new LogWiever(duzyazi);
            gosterici.ShowDialog();
        }

        private void LogKaydet_Click(object sender, EventArgs e)
        {
            if(Motor_Konum_Kaydet.Enabled == true)
            {
                string ilksatir = "";
                for (int i = 0; i < motorKonum.Length; i++)
                {
                    ilksatir = ilksatir + "&" + motorKonum[i];
                }
                ilksatir = "!" + ilksatir + "&" + "!";
                bellek[0] = ilksatir;

                for (int i = 1; i < bellek.Length; i++)
                {
                    bellek[i] = motorYon[i - 1];
                }
                duzyazi = "";
                for (int i = 0; i < bellek.Length; i++)
                {
                    duzyazi = duzyazi + bellek[i] + Environment.NewLine;
                }
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Motor_Conf.txt", duzyazi);
                Log_Gonder.Enabled = true;
            }
            else
            {
                MessageBox.Show("Motor konumları kaydedilmedi. Kaydetmek için Motor Konum Kaydet butonuna basınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Log_Gonder.Enabled = false;
            }
        }
    
        private void MotorYonSelected(object sender, EventArgs e)
        {
            Motor_Konum_Kaydet.Enabled = true;
            if (MotorDuzeni.SelectedIndex == 1)
            {
                for (int i = 0; i < ComboBoxlerYon.Length-2; i++)
                {
                    if (ComboBoxlerYon[i].SelectedIndex == 0)
                    {
                        Motor_Konum_Kaydet.Enabled = false;
                        break;
                    }
                }
            }
            else if (MotorDuzeni.SelectedIndex == 2)
            {
                for (int i = 0; i < ComboBoxlerYon.Length; i++)
                {
                    if (ComboBoxlerYon[i].SelectedIndex == 0)
                    {
                        Motor_Konum_Kaydet.Enabled = false;
                        break;
                    }
                }
            }

        }

        private void MotorKonumSelected(object sender, EventArgs e)
        {
            ComboBox currentComboBox = sender as ComboBox;
            foreach (ComboBox comboBox in ComboBoxlerYon)
            {
                if (comboBox != currentComboBox && comboBox.SelectedItem == currentComboBox.SelectedItem)
                {
                    if (currentComboBox.GetItemText(currentComboBox.SelectedItem) != "-")
                    {
                        MessageBox.Show($"{currentComboBox.SelectedItem} zaten başka bir ComboBox'ta seçili.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    currentComboBox.SelectedIndex = 0;
                    break;
                }
            }
        }

        private void conficeaktar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Hareket_Tanimla_SelectedIndexChanged(object sender, EventArgs e)
        {
            // O kısımda hangi ayar kayıtlı ise o ayarı ekrana getir
        }

        private void MotorDuzeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MotorDuzeni.SelectedIndex == 0)
            {
                for (int i = 0; i < ComboBoxlerYon.Length; i++) { ComboBoxlerYon[i].Visible = false; }
                for (int i = 0; i < ComboBoxlerMotor.Length; i++){ComboBoxlerMotor[i].Visible = false;}
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label19.Text = "";
                label8.Text = "";

                label11.Text = "";
                label12.Text = "";
                label13.Text = "";
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";
                label17.Text = "";
                label1.Text = "";
                pictureBox1.Image = null;
                Motor_Konum_Kaydet.Enabled = false;

                //for (int i = 0; i < ComboBoxlerYon.Length; i++) { ComboBoxlerYon[i].SelectedIndex = 0; }
            }
            if (MotorDuzeni.SelectedIndex == 1)
            {
                for (int i = 0; i < ComboBoxlerYon.Length-2; i++){ComboBoxlerYon[i].Visible = true;}
                ComboBoxlerYon[6].Visible = false;
                ComboBoxlerYon[7].Visible = false;
                label2.Text = "Ön Sol";
                label3.Text = "Ön Sağ";
                label4.Text = "Orta Sol";
                label5.Text = "Orta Sağ";
                label6.Text = "Arka Sol";
                label7.Text = "Arka Sağ";
                label8.Text = "";
                label19.Text = "";

                label11.Text = "M1";
                label12.Text = "M2";
                label13.Text = "M3";
                label14.Text = "M4";
                label15.Text = "M5";
                label16.Text = "M6";
                label17.Text = "";
                label1.Text = "";
                for (int i = 0; i < ComboBoxlerYon.Length; i++) { ComboBoxlerYon[i].SelectedIndex = 0; }
                for (int i = 0; i < ComboBoxlerMotor.Length; i++) { ComboBoxlerMotor[i].SelectedIndex = 0; }
                for (int i = 0; i < ComboBoxlerMotor.Length - 2; i++){ComboBoxlerMotor[i].Visible = true; }
                for (int i = 0; i < harfler.Length; i++) { harfler[i].ForeColor = Color.Red; }
                comboBox_Yon_M7.Visible = false;
                comboBox_Yon_M8.Visible = false;
                pictureBox1.Image = Properties.Resources.Piri_Reis;
                bellek = new string[11];
                motorYon = new string[10] { "", "", "", "", "", "", "", "", "", "" };
                motorKonum = new string[8];
            }
            else if (MotorDuzeni.SelectedIndex == 2)
            {
                for (int i = 0; i < ComboBoxlerMotor.Length; i++){ComboBoxlerMotor[i].Visible = true;}
                for (int i = 0; i < ComboBoxlerYon.Length; i++){ComboBoxlerYon[i].Visible = true;}
                label2.Text = "Ön Sol Batma";
                label3.Text = "Ön Sağ Batma";
                label4.Text = "Ön Sol";
                label5.Text = "Ön Sağ";
                label6.Text = "Arka Sol";
                label7.Text = "Arka Sağ";
                label8.Text = "Arka Sağ Batma";
                label19.Text = "Arka Sol Batma";

                label11.Text = "M1";
                label12.Text = "M2";
                label13.Text = "M3";
                label14.Text = "M4";
                label15.Text = "M5";
                label16.Text = "M6";
                label17.Text = "M7";
                label1.Text = "M8";

                for (int i = 0; i < ComboBoxlerYon.Length; i++) { ComboBoxlerYon[i].SelectedIndex = 0; }
                for (int i = 0; i < ComboBoxlerMotor.Length; i++) { ComboBoxlerMotor[i].SelectedIndex = 0; }
                for (int i = 0; i < harfler.Length; i++) { harfler[i].ForeColor = Color.Red; }
                pictureBox1.Image = Properties.Resources.Homeland;

                bellek = new string[11];
                motorYon = new string[10] { "", "", "", "", "", "", "", "", "", "" };
                motorKonum = new string[8];
    }
        }
    }
}
