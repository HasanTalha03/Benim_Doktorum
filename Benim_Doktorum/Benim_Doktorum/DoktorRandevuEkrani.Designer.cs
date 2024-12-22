namespace Benim_Doktorum
{
    partial class DoktorRandevuEkrani
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LblHastaAd = new System.Windows.Forms.Label();
            this.LblHastaSoyad = new System.Windows.Forms.Label();
            this.LblDoktorAd = new System.Windows.Forms.Label();
            this.LblDoktorSoyad = new System.Windows.Forms.Label();
            this.LblRandevuTrh = new System.Windows.Forms.Label();
            this.LblRandevuSaati = new System.Windows.Forms.Label();
            this.BtnRandevuBaslat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblRandevularım = new System.Windows.Forms.Label();
            this.LblBolum = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.BtnUrlKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(73, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(903, 260);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LblHastaAd
            // 
            this.LblHastaAd.AutoSize = true;
            this.LblHastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaAd.Location = new System.Drawing.Point(74, 122);
            this.LblHastaAd.Name = "LblHastaAd";
            this.LblHastaAd.Size = new System.Drawing.Size(83, 20);
            this.LblHastaAd.TabIndex = 8;
            this.LblHastaAd.Text = "Hasta Adı";
            // 
            // LblHastaSoyad
            // 
            this.LblHastaSoyad.AutoSize = true;
            this.LblHastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaSoyad.Location = new System.Drawing.Point(208, 122);
            this.LblHastaSoyad.Name = "LblHastaSoyad";
            this.LblHastaSoyad.Size = new System.Drawing.Size(59, 20);
            this.LblHastaSoyad.TabIndex = 9;
            this.LblHastaSoyad.Text = "Soyadı";
            // 
            // LblDoktorAd
            // 
            this.LblDoktorAd.AutoSize = true;
            this.LblDoktorAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDoktorAd.Location = new System.Drawing.Point(339, 122);
            this.LblDoktorAd.Name = "LblDoktorAd";
            this.LblDoktorAd.Size = new System.Drawing.Size(88, 20);
            this.LblDoktorAd.TabIndex = 10;
            this.LblDoktorAd.Text = "Doktor Adı";
            // 
            // LblDoktorSoyad
            // 
            this.LblDoktorSoyad.AutoSize = true;
            this.LblDoktorSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDoktorSoyad.Location = new System.Drawing.Point(487, 122);
            this.LblDoktorSoyad.Name = "LblDoktorSoyad";
            this.LblDoktorSoyad.Size = new System.Drawing.Size(114, 20);
            this.LblDoktorSoyad.TabIndex = 11;
            this.LblDoktorSoyad.Text = "Doktor Soyadı";
            // 
            // LblRandevuTrh
            // 
            this.LblRandevuTrh.AutoSize = true;
            this.LblRandevuTrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRandevuTrh.Location = new System.Drawing.Point(719, 122);
            this.LblRandevuTrh.Name = "LblRandevuTrh";
            this.LblRandevuTrh.Size = new System.Drawing.Size(121, 20);
            this.LblRandevuTrh.TabIndex = 12;
            this.LblRandevuTrh.Text = "Randevu Tarihi";
            // 
            // LblRandevuSaati
            // 
            this.LblRandevuSaati.AutoSize = true;
            this.LblRandevuSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRandevuSaati.Location = new System.Drawing.Point(859, 122);
            this.LblRandevuSaati.Name = "LblRandevuSaati";
            this.LblRandevuSaati.Size = new System.Drawing.Size(117, 20);
            this.LblRandevuSaati.TabIndex = 13;
            this.LblRandevuSaati.Text = "Randevu Saati";
            // 
            // BtnRandevuBaslat
            // 
            this.BtnRandevuBaslat.Location = new System.Drawing.Point(426, 498);
            this.BtnRandevuBaslat.Name = "BtnRandevuBaslat";
            this.BtnRandevuBaslat.Size = new System.Drawing.Size(162, 52);
            this.BtnRandevuBaslat.TabIndex = 14;
            this.BtnRandevuBaslat.Text = "Randevu Başlat";
            this.BtnRandevuBaslat.UseVisualStyleBackColor = true;
            this.BtnRandevuBaslat.Click += new System.EventHandler(this.BtnRandevuBaslat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblRandevularım
            // 
            this.LblRandevularım.AutoSize = true;
            this.LblRandevularım.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRandevularım.Location = new System.Drawing.Point(67, 45);
            this.LblRandevularım.Name = "LblRandevularım";
            this.LblRandevularım.Size = new System.Drawing.Size(185, 35);
            this.LblRandevularım.TabIndex = 16;
            this.LblRandevularım.Text = "Randevularım:";
            // 
            // LblBolum
            // 
            this.LblBolum.AutoSize = true;
            this.LblBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBolum.Location = new System.Drawing.Point(632, 122);
            this.LblBolum.Name = "LblBolum";
            this.LblBolum.Size = new System.Drawing.Size(57, 20);
            this.LblBolum.TabIndex = 17;
            this.LblBolum.Text = "Bölüm";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(293, 470);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(100, 22);
            this.TxtUrl.TabIndex = 18;
            this.TxtUrl.Visible = false;
            // 
            // BtnUrlKaydet
            // 
            this.BtnUrlKaydet.Location = new System.Drawing.Point(281, 498);
            this.BtnUrlKaydet.Name = "BtnUrlKaydet";
            this.BtnUrlKaydet.Size = new System.Drawing.Size(139, 52);
            this.BtnUrlKaydet.TabIndex = 19;
            this.BtnUrlKaydet.Text = "Url Kaydet";
            this.BtnUrlKaydet.UseVisualStyleBackColor = true;
            this.BtnUrlKaydet.Visible = false;
            this.BtnUrlKaydet.Click += new System.EventHandler(this.BtnUrlKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lütfen Randevuyu başlattıktan sonra geri dönüp url yi kaydetmeyi unutmayın!";
            // 
            // DoktorRandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1016, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUrlKaydet);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.LblBolum);
            this.Controls.Add(this.LblRandevularım);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnRandevuBaslat);
            this.Controls.Add(this.LblRandevuSaati);
            this.Controls.Add(this.LblRandevuTrh);
            this.Controls.Add(this.LblDoktorSoyad);
            this.Controls.Add(this.LblDoktorAd);
            this.Controls.Add(this.LblHastaSoyad);
            this.Controls.Add(this.LblHastaAd);
            this.Controls.Add(this.listBox1);
            this.Name = "DoktorRandevuEkrani";
            this.Text = "DoktorRandevuEkrani";
            this.Load += new System.EventHandler(this.DoktorRandevuEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LblHastaAd;
        private System.Windows.Forms.Label LblHastaSoyad;
        private System.Windows.Forms.Label LblDoktorAd;
        private System.Windows.Forms.Label LblDoktorSoyad;
        private System.Windows.Forms.Label LblRandevuTrh;
        private System.Windows.Forms.Label LblRandevuSaati;
        private System.Windows.Forms.Button BtnRandevuBaslat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblRandevularım;
        private System.Windows.Forms.Label LblBolum;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Button BtnUrlKaydet;
        private System.Windows.Forms.Label label1;
    }
}