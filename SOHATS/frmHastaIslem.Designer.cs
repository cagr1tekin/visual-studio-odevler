namespace SOHATS
{
    partial class frmHastaIslem
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
            System.Windows.Forms.Label lblDosyaNo;
            System.Windows.Forms.Label lblAd;
            System.Windows.Forms.Label lblSoyad;
            System.Windows.Forms.Label lblTcNo;
            System.Windows.Forms.Label lblPoliklinik;
            System.Windows.Forms.Label lblIslem;
            System.Windows.Forms.Label lblDrKod;
            System.Windows.Forms.Label lblMiktar;
            System.Windows.Forms.Label lblSiraNo;
            System.Windows.Forms.Label lblKayitSaati;
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtDrKod = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtKayitSaati = new System.Windows.Forms.TextBox();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.dgvIslemler = new System.Windows.Forms.DataGridView();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnTaburcu = new System.Windows.Forms.Button();
            lblDosyaNo = new System.Windows.Forms.Label();
            lblAd = new System.Windows.Forms.Label();
            lblSoyad = new System.Windows.Forms.Label();
            lblTcNo = new System.Windows.Forms.Label();
            lblPoliklinik = new System.Windows.Forms.Label();
            lblIslem = new System.Windows.Forms.Label();
            lblDrKod = new System.Windows.Forms.Label();
            lblMiktar = new System.Windows.Forms.Label();
            lblSiraNo = new System.Windows.Forms.Label();
            lblKayitSaati = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDosyaNo
            // 
            lblDosyaNo.AutoSize = true;
            lblDosyaNo.Location = new System.Drawing.Point(20, 23);
            lblDosyaNo.Name = "lblDosyaNo";
            lblDosyaNo.Size = new System.Drawing.Size(72, 16);
            lblDosyaNo.TabIndex = 16;
            lblDosyaNo.Text = "Dosya No:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new System.Drawing.Point(20, 63);
            lblAd.Name = "lblAd";
            lblAd.Size = new System.Drawing.Size(27, 16);
            lblAd.TabIndex = 17;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new System.Drawing.Point(200, 63);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new System.Drawing.Size(50, 16);
            lblSoyad.TabIndex = 18;
            lblSoyad.Text = "Soyad:";
            // 
            // lblTcNo
            // 
            lblTcNo.AutoSize = true;
            lblTcNo.Location = new System.Drawing.Point(380, 63);
            lblTcNo.Name = "lblTcNo";
            lblTcNo.Size = new System.Drawing.Size(49, 16);
            lblTcNo.TabIndex = 19;
            lblTcNo.Text = "TC No:";
            // 
            // lblPoliklinik
            // 
            lblPoliklinik.AutoSize = true;
            lblPoliklinik.Location = new System.Drawing.Point(20, 113);
            lblPoliklinik.Name = "lblPoliklinik";
            lblPoliklinik.Size = new System.Drawing.Size(65, 16);
            lblPoliklinik.TabIndex = 20;
            lblPoliklinik.Text = "Poliklinik:";
            // 
            // lblIslem
            // 
            lblIslem.AutoSize = true;
            lblIslem.Location = new System.Drawing.Point(200, 113);
            lblIslem.Name = "lblIslem";
            lblIslem.Size = new System.Drawing.Size(42, 16);
            lblIslem.TabIndex = 21;
            lblIslem.Text = "İşlem:";
            // 
            // lblDrKod
            // 
            lblDrKod.AutoSize = true;
            lblDrKod.Location = new System.Drawing.Point(380, 113);
            lblDrKod.Name = "lblDrKod";
            lblDrKod.Size = new System.Drawing.Size(54, 16);
            lblDrKod.TabIndex = 22;
            lblDrKod.Text = "Dr. Kod:";
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new System.Drawing.Point(500, 113);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new System.Drawing.Size(46, 16);
            lblMiktar.TabIndex = 23;
            lblMiktar.Text = "Miktar:";
            // 
            // lblSiraNo
            // 
            lblSiraNo.AutoSize = true;
            lblSiraNo.Location = new System.Drawing.Point(620, 23);
            lblSiraNo.Name = "lblSiraNo";
            lblSiraNo.Size = new System.Drawing.Size(55, 16);
            lblSiraNo.TabIndex = 24;
            lblSiraNo.Text = "Sıra No:";
            // 
            // lblKayitSaati
            // 
            lblKayitSaati.AutoSize = true;
            lblKayitSaati.Location = new System.Drawing.Point(620, 63);
            lblKayitSaati.Name = "lblKayitSaati";
            lblKayitSaati.Size = new System.Drawing.Size(73, 16);
            lblKayitSaati.TabIndex = 25;
            lblKayitSaati.Text = "Kayıt Saati:";
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Location = new System.Drawing.Point(100, 20);
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(100, 22);
            this.txtDosyaNo.TabIndex = 0;
            this.txtDosyaNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDosyaNo_KeyDown);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(60, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(120, 22);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(260, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(440, 60);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(100, 22);
            this.txtTcNo.TabIndex = 3;
            // 
            // txtDrKod
            // 
            this.txtDrKod.Location = new System.Drawing.Point(440, 110);
            this.txtDrKod.Name = "txtDrKod";
            this.txtDrKod.Size = new System.Drawing.Size(50, 22);
            this.txtDrKod.TabIndex = 4;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(550, 110);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(60, 22);
            this.txtMiktar.TabIndex = 5;
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(700, 20);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.ReadOnly = true;
            this.txtSiraNo.Size = new System.Drawing.Size(60, 22);
            this.txtSiraNo.TabIndex = 7;
            // 
            // txtKayitSaati
            // 
            this.txtKayitSaati.Location = new System.Drawing.Point(700, 60);
            this.txtKayitSaati.Name = "txtKayitSaati";
            this.txtKayitSaati.ReadOnly = true;
            this.txtKayitSaati.Size = new System.Drawing.Size(60, 22);
            this.txtKayitSaati.TabIndex = 6;
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(90, 110);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(100, 24);
            this.cmbPoliklinik.TabIndex = 8;
            // 
            // cmbIslem
            // 
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Location = new System.Drawing.Point(250, 110);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(120, 24);
            this.cmbIslem.TabIndex = 9;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(210, 18);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(50, 26);
            this.btnBul.TabIndex = 12;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(630, 108);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(60, 28);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvIslemler
            // 
            this.dgvIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIslemler.Location = new System.Drawing.Point(20, 150);
            this.dgvIslemler.Name = "dgvIslemler";
            this.dgvIslemler.RowHeadersWidth = 51;
            this.dgvIslemler.RowTemplate.Height = 24;
            this.dgvIslemler.Size = new System.Drawing.Size(740, 200);
            this.dgvIslemler.TabIndex = 10;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(550, 370);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(54, 25);
            this.lblToplamTutar.TabIndex = 11;
            this.lblToplamTutar.Text = "0.00";
            // 
            // btnTaburcu
            // 
            this.btnTaburcu.Location = new System.Drawing.Point(20, 370);
            this.btnTaburcu.Name = "btnTaburcu";
            this.btnTaburcu.Size = new System.Drawing.Size(100, 35);
            this.btnTaburcu.TabIndex = 15;
            this.btnTaburcu.Text = "Taburcu";
            this.btnTaburcu.UseVisualStyleBackColor = true;
            this.btnTaburcu.Click += new System.EventHandler(this.btnTaburcu_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(130, 370);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(100, 35);
            this.btnYazdir.TabIndex = 14;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // frmHastaIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(lblKayitSaati);
            this.Controls.Add(lblSiraNo);
            this.Controls.Add(lblMiktar);
            this.Controls.Add(lblDrKod);
            this.Controls.Add(lblIslem);
            this.Controls.Add(lblPoliklinik);
            this.Controls.Add(lblTcNo);
            this.Controls.Add(lblSoyad);
            this.Controls.Add(lblAd);
            this.Controls.Add(lblDosyaNo);
            this.Controls.Add(this.btnTaburcu);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.dgvIslemler);
            this.Controls.Add(this.cmbIslem);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.txtSiraNo);
            this.Controls.Add(this.txtKayitSaati);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtDrKod);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtDosyaNo);
            this.Name = "frmHastaIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta İşlemleri";
            this.Load += new System.EventHandler(this.frmHastaIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtDrKod;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtKayitSaati;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.DataGridView dgvIslemler;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnTaburcu;
    }
}