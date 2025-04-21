namespace AUV_UI
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.terminal = new System.Windows.Forms.TextBox();
            this.komut_satiri = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipadress_label = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.config_button = new System.Windows.Forms.Button();
            this.islemi_Durdur = new System.Windows.Forms.Button();
            this.dosya_gonder = new System.Windows.Forms.Button();
            this.desktop_listesi = new System.Windows.Forms.Button();
            this.baglantiyi_kes = new System.Windows.Forms.Button();
            this.komutu_calistir = new System.Windows.Forms.Button();
            this.baglan = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ControlPanelButton = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // terminal
            // 
            this.terminal.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.terminal.ForeColor = System.Drawing.Color.Lime;
            this.terminal.Location = new System.Drawing.Point(344, 34);
            this.terminal.Multiline = true;
            this.terminal.Name = "terminal";
            this.terminal.ReadOnly = true;
            this.terminal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.terminal.Size = new System.Drawing.Size(509, 351);
            this.terminal.TabIndex = 32;
            // 
            // komut_satiri
            // 
            this.komut_satiri.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.komut_satiri.ForeColor = System.Drawing.Color.Blue;
            this.komut_satiri.Location = new System.Drawing.Point(345, 391);
            this.komut_satiri.Name = "komut_satiri";
            this.komut_satiri.Size = new System.Drawing.Size(508, 22);
            this.komut_satiri.TabIndex = 29;
            this.komut_satiri.Text = "python Desktop/deneme.py";
            this.komut_satiri.TextChanged += new System.EventHandler(this.komut_satiri_TextChanged);
            // 
            // password_label
            // 
            this.password_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_label.Location = new System.Drawing.Point(214, 74);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(115, 22);
            this.password_label.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(341, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Terminal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(133, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Bağlantı\r\nDurumu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(171, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Şifre";
            // 
            // username_label
            // 
            this.username_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_label.Location = new System.Drawing.Point(214, 46);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(115, 22);
            this.username_label.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(120, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // ipadress_label
            // 
            this.ipadress_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipadress_label.Location = new System.Drawing.Point(214, 18);
            this.ipadress_label.Name = "ipadress_label";
            this.ipadress_label.Size = new System.Drawing.Size(115, 22);
            this.ipadress_label.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(144, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "IP Adresi";
            // 
            // config_button
            // 
            this.config_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.config_button.Location = new System.Drawing.Point(16, 190);
            this.config_button.Name = "config_button";
            this.config_button.Size = new System.Drawing.Size(124, 41);
            this.config_button.TabIndex = 17;
            this.config_button.Text = "Konfigürasyon Ekranı";
            this.config_button.UseVisualStyleBackColor = true;
            this.config_button.Click += new System.EventHandler(this.config_button_Click);
            // 
            // islemi_Durdur
            // 
            this.islemi_Durdur.Enabled = false;
            this.islemi_Durdur.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemi_Durdur.Location = new System.Drawing.Point(345, 419);
            this.islemi_Durdur.Name = "islemi_Durdur";
            this.islemi_Durdur.Size = new System.Drawing.Size(111, 28);
            this.islemi_Durdur.TabIndex = 16;
            this.islemi_Durdur.Text = "İşlemi Durdur";
            this.islemi_Durdur.UseVisualStyleBackColor = true;
            this.islemi_Durdur.Click += new System.EventHandler(this.islemi_Durdur_Click);
            // 
            // dosya_gonder
            // 
            this.dosya_gonder.Enabled = false;
            this.dosya_gonder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosya_gonder.Location = new System.Drawing.Point(16, 143);
            this.dosya_gonder.Name = "dosya_gonder";
            this.dosya_gonder.Size = new System.Drawing.Size(90, 41);
            this.dosya_gonder.TabIndex = 13;
            this.dosya_gonder.Text = "Dosya Gönder";
            this.dosya_gonder.UseVisualStyleBackColor = true;
            this.dosya_gonder.Click += new System.EventHandler(this.dosya_gonder_Click);
            // 
            // desktop_listesi
            // 
            this.desktop_listesi.Enabled = false;
            this.desktop_listesi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.desktop_listesi.Location = new System.Drawing.Point(16, 96);
            this.desktop_listesi.Name = "desktop_listesi";
            this.desktop_listesi.Size = new System.Drawing.Size(90, 41);
            this.desktop_listesi.TabIndex = 12;
            this.desktop_listesi.Text = "Dosya Al";
            this.desktop_listesi.UseVisualStyleBackColor = true;
            this.desktop_listesi.Click += new System.EventHandler(this.desktop_listesi_Click);
            // 
            // baglantiyi_kes
            // 
            this.baglantiyi_kes.Enabled = false;
            this.baglantiyi_kes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglantiyi_kes.Location = new System.Drawing.Point(16, 49);
            this.baglantiyi_kes.Name = "baglantiyi_kes";
            this.baglantiyi_kes.Size = new System.Drawing.Size(90, 41);
            this.baglantiyi_kes.TabIndex = 11;
            this.baglantiyi_kes.Text = "Bağlantıyı Kes";
            this.baglantiyi_kes.UseVisualStyleBackColor = true;
            this.baglantiyi_kes.Click += new System.EventHandler(this.baglantiyi_kes_Click);
            // 
            // komutu_calistir
            // 
            this.komutu_calistir.Enabled = false;
            this.komutu_calistir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.komutu_calistir.Location = new System.Drawing.Point(484, 420);
            this.komutu_calistir.Name = "komutu_calistir";
            this.komutu_calistir.Size = new System.Drawing.Size(117, 27);
            this.komutu_calistir.TabIndex = 18;
            this.komutu_calistir.Text = "Komutu Çalıştır";
            this.komutu_calistir.UseVisualStyleBackColor = true;
            this.komutu_calistir.Click += new System.EventHandler(this.komutu_calistir_Click);
            // 
            // baglan
            // 
            this.baglan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglan.Location = new System.Drawing.Point(16, 15);
            this.baglan.Name = "baglan";
            this.baglan.Size = new System.Drawing.Size(90, 28);
            this.baglan.TabIndex = 10;
            this.baglan.Text = "Bağlan";
            this.baglan.UseVisualStyleBackColor = true;
            this.baglan.Click += new System.EventHandler(this.baglan_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::AUV_UI.Properties.Resources.pytho;
            this.pictureBox10.Location = new System.Drawing.Point(289, 361);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(40, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 42;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::AUV_UI.Properties.Resources.Raspberry_Logo;
            this.pictureBox7.Location = new System.Drawing.Point(289, 407);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 41;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::AUV_UI.Properties.Resources.Csharp_Logo;
            this.pictureBox9.Location = new System.Drawing.Point(245, 361);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 40;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::AUV_UI.Properties.Resources.C_Logo;
            this.pictureBox8.Location = new System.Drawing.Point(199, 361);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 39;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AUV_UI.Properties.Resources.Windows_logo;
            this.pictureBox6.Location = new System.Drawing.Point(243, 407);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AUV_UI.Properties.Resources.ST_logo;
            this.pictureBox5.Location = new System.Drawing.Point(199, 407);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AUV_UI.Properties.Resources.rederror_bw;
            this.pictureBox2.Location = new System.Drawing.Point(199, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AUV_UI.Properties.Resources.mys_black_logo;
            this.pictureBox4.Location = new System.Drawing.Point(174, 181);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 156);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // ControlPanelButton
            // 
            this.ControlPanelButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ControlPanelButton.Location = new System.Drawing.Point(16, 237);
            this.ControlPanelButton.Name = "ControlPanelButton";
            this.ControlPanelButton.Size = new System.Drawing.Size(124, 32);
            this.ControlPanelButton.TabIndex = 45;
            this.ControlPanelButton.Text = "Kontrol Paneli";
            this.ControlPanelButton.UseVisualStyleBackColor = true;
            this.ControlPanelButton.Click += new System.EventHandler(this.ControlPanelButton_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::AUV_UI.Properties.Resources.Teknofest_logo;
            this.pictureBox11.Location = new System.Drawing.Point(16, 275);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(144, 80);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 46;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AUV_UI.Properties.Resources.daftpunktocat_guy;
            this.pictureBox1.Location = new System.Drawing.Point(265, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::AUV_UI.Properties.Resources.kapsullogo;
            this.pictureBox12.Location = new System.Drawing.Point(112, 361);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(80, 86);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 48;
            this.pictureBox12.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(631, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "İşlem ID:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AUV_UI.Properties.Resources.su_hd;
            this.pictureBox3.Location = new System.Drawing.Point(16, 361);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(872, 459);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.ControlPanelButton);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.terminal);
            this.Controls.Add(this.komut_satiri);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipadress_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.config_button);
            this.Controls.Add(this.islemi_Durdur);
            this.Controls.Add(this.dosya_gonder);
            this.Controls.Add(this.desktop_listesi);
            this.Controls.Add(this.baglantiyi_kes);
            this.Controls.Add(this.komutu_calistir);
            this.Controls.Add(this.baglan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AquaDesk AUV Kontrol İstasyonu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox komut_satiri;
        public System.Windows.Forms.TextBox password_label;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox username_label;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ipadress_label;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button config_button;
        public System.Windows.Forms.Button islemi_Durdur;
        public System.Windows.Forms.Button dosya_gonder;
        public System.Windows.Forms.Button desktop_listesi;
        public System.Windows.Forms.Button baglantiyi_kes;
        public System.Windows.Forms.Button komutu_calistir;
        public System.Windows.Forms.Button baglan;
        public System.Windows.Forms.TextBox terminal;
        public System.Windows.Forms.Button ControlPanelButton;
        public System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox12;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox pictureBox3;
    }
}

