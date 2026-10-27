namespace SOHATS
{
    partial class frmPoliklinik
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
            System.Windows.Forms.Label lblPoliklinikAd;
            System.Windows.Forms.Label lblAciklama;
            this.txtPoliklinikAd = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.chkGecerli = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            lblPoliklinikAd = new System.Windows.Forms.Label();
            lblAciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPoliklinikAd
            // 
            lblPoliklinikAd.AutoSize = true;
            lblPoliklinikAd.Location = new System.Drawing.Point(30, 33);
            lblPoliklinikAd.Name = "lblPoliklinikAd";
            lblPoliklinikAd.Size = new System.Drawing.Size(88, 16);
            lblPoliklinikAd.TabIndex = 6;
            lblPoliklinikAd.Text = "Poliklinik Adı:";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Location = new System.Drawing.Point(30, 73);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new System.Drawing.Size(66, 16);
            lblAciklama.TabIndex = 7;
            lblAciklama.Text = "Açıklama:";
            // 
            // txtPoliklinikAd
            // 
            this.txtPoliklinikAd.Location = new System.Drawing.Point(130, 30);
            this.txtPoliklinikAd.Name = "txtPoliklinikAd";
            this.txtPoliklinikAd.Size = new System.Drawing.Size(200, 22);
            this.txtPoliklinikAd.TabIndex = 0;
            this.txtPoliklinikAd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPoliklinikAd_KeyDown);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(130, 70);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 80);
            this.txtAciklama.TabIndex = 1;
            // 
            // chkGecerli
            // 
            this.chkGecerli.AutoSize = true;
            this.chkGecerli.Location = new System.Drawing.Point(350, 32);
            this.chkGecerli.Name = "chkGecerli";
            this.chkGecerli.Size = new System.Drawing.Size(71, 20);
            this.chkGecerli.TabIndex = 2;
            this.chkGecerli.Text = "Geçerli";
            this.chkGecerli.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(130, 170);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 30);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(220, 170);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 30);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(310, 170);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 30);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmPoliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(lblAciklama);
            this.Controls.Add(lblPoliklinikAd);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chkGecerli);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPoliklinikAd);
            this.Name = "frmPoliklinik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliklinik Tanıtma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPoliklinikAd;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.CheckBox chkGecerli;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}