namespace AUV_UI
{
    partial class UploadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fileTreeView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.NewFolderAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(98, 398);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 22);
            this.textBox1.TabIndex = 5;
            // 
            // fileTreeView
            // 
            this.fileTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileTreeView.Indent = 25;
            this.fileTreeView.ItemHeight = 25;
            this.fileTreeView.Location = new System.Drawing.Point(12, 12);
            this.fileTreeView.Name = "fileTreeView";
            this.fileTreeView.Size = new System.Drawing.Size(411, 380);
            this.fileTreeView.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seçilen Dosyaları Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DosyaGonder);
            // 
            // NewFolderAdd
            // 
            this.NewFolderAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.NewFolderAdd.Location = new System.Drawing.Point(98, 426);
            this.NewFolderAdd.Name = "NewFolderAdd";
            this.NewFolderAdd.Size = new System.Drawing.Size(175, 28);
            this.NewFolderAdd.TabIndex = 6;
            this.NewFolderAdd.Text = "Yeni Klasör oluştur";
            this.NewFolderAdd.UseVisualStyleBackColor = true;
            this.NewFolderAdd.Click += new System.EventHandler(this.NewFolderAdd_Click);
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 466);
            this.Controls.Add(this.NewFolderAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileTreeView);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya Transfer Ekranı";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView fileTreeView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NewFolderAdd;
    }
}