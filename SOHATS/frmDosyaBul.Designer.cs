namespace SOHATS
{
    partial class frmDosyaBul
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
            System.Windows.Forms.Label lblArama;
            this.txtAramaKriteri = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.dgvSonuclar = new System.Windows.Forms.DataGridView();
            lblArama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Location = new System.Drawing.Point(20, 23);
            lblArama.Name = "lblArama";
            lblArama.Size = new System.Drawing.Size(88, 16);
            lblArama.TabIndex = 4;
            lblArama.Text = "Arama Kriteri:";
            // 
            // txtAramaKriteri
            // 
            this.txtAramaKriteri.Location = new System.Drawing.Point(120, 20);
            this.txtAramaKriteri.Name = "txtAramaKriteri";
            this.txtAramaKriteri.Size = new System.Drawing.Size(200, 22);
            this.txtAramaKriteri.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(330, 18);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 26);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(20, 380);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(100, 30);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // dgvSonuclar
            // 
            this.dgvSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuclar.Location = new System.Drawing.Point(20, 60);
            this.dgvSonuclar.Name = "dgvSonuclar";
            this.dgvSonuclar.RowHeadersWidth = 51;
            this.dgvSonuclar.RowTemplate.Height = 24;
            this.dgvSonuclar.Size = new System.Drawing.Size(500, 300);
            this.dgvSonuclar.TabIndex = 3;
            this.dgvSonuclar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSonuclar_CellDoubleClick);
            // 
            // frmDosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 430);
            this.Controls.Add(lblArama);
            this.Controls.Add(this.dgvSonuclar);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAramaKriteri);
            this.Name = "frmDosyaBul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya Arama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAramaKriteri;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.DataGridView dgvSonuclar;
    }
}