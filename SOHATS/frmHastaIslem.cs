using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmHastaIslem : Form
    {
        public frmHastaIslem()
        {
            InitializeComponent();
        }

        private void frmHastaIslem_Load(object sender, EventArgs e)
        {
            PoliklinikleriYukle();
            IslemleriYukle();
            txtKayitSaati.Text = DateTime.Now.ToShortTimeString();
            Temizle();
        }

        private void PoliklinikleriYukle()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT poliklinikAdi FROM Poliklinik", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    cmbPoliklinik.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbPoliklinik.Items.Add(dr["poliklinikAdi"].ToString());
                    }
                }
                catch { }
            }
        }

        private void IslemleriYukle()
        {
            // Örnek işlemler
            cmbIslem.Items.Add("Muayene");
            cmbIslem.Items.Add("Kan Tahlili");
            cmbIslem.Items.Add("Röntgen");
            cmbIslem.Items.Add("EKG");
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmDosyaBul frm = new frmDosyaBul();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtDosyaNo.Text = frm.SecilenDosyaNo;
                HastaBilgileriniGetir(txtDosyaNo.Text);
                OncekiIslemleriGetir(txtDosyaNo.Text);
            }
        }

        private void txtDosyaNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HastaBilgileriniGetir(txtDosyaNo.Text);
                OncekiIslemleriGetir(txtDosyaNo.Text);
            }
        }

        private void HastaBilgileriniGetir(string dosyaNo)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Hasta WHERE dosyaNo = @no", conn);
                    cmd.Parameters.AddWithValue("@no", dosyaNo);
                    
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtAd.Text = dr["ad"].ToString();
                        txtSoyad.Text = dr["soyad"].ToString();
                        txtTcNo.Text = dr["tcNo"].ToString();
                        // Kurum adı vs varsa doldurulabilir
                    }
                    else
                    {
                        MessageBox.Show("Hasta bulunamadı.");
                        TemizleHasta();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void OncekiIslemleriGetir(string dosyaNo)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Sadece bugünkü veya taburcu olmamış işlemleri getirelim
                    string query = "SELECT * FROM Sevk WHERE dosyaNo = @no AND taburcu = 'Hayır'"; 
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@no", dosyaNo);
                    
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    dgvIslemler.DataSource = dt;
                    ToplamTutarHesapla(dt);
                    
                    // Sıra no belirle (Mevcut kayıt sayısı + 1)
                    txtSiraNo.Text = (dt.Rows.Count + 1).ToString();
                }
                catch { }
            }
        }

        private void ToplamTutarHesapla(DataTable dt)
        {
            decimal toplam = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["toplamTutar"] != DBNull.Value)
                    toplam += Convert.ToDecimal(dr["toplamTutar"]);
            }
            lblToplamTutar.Text = toplam.ToString("C2");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDosyaNo.Text) || string.IsNullOrEmpty(cmbPoliklinik.Text))
            {
                MessageBox.Show("Lütfen dosya no ve poliklinik seçiniz.");
                return;
            }

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Sevk (sevkTarihi, dosyaNo, poliklinik, saat, yapilanIslem, drKod, miktar, birimFiyat, sira, toplamTutar, taburcu) " +
                                   "VALUES (@tarih, @dosya, @poly, @saat, @islem, @dr, @miktar, @fiyat, @sira, @toplam, @taburcu)";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now.Date); // Sadece tarih
                    cmd.Parameters.AddWithValue("@dosya", txtDosyaNo.Text);
                    cmd.Parameters.AddWithValue("@poly", cmbPoliklinik.Text);
                    cmd.Parameters.AddWithValue("@saat", txtKayitSaati.Text);
                    cmd.Parameters.AddWithValue("@islem", cmbIslem.Text);
                    cmd.Parameters.AddWithValue("@dr", txtDrKod.Text);
                    
                    int miktar = int.TryParse(txtMiktar.Text, out int m) ? m : 1;
                    decimal birimFiyat = 100; // Örnek sabit fiyat
                    if (cmbIslem.Text == "Kan Tahlili") birimFiyat = 50;
                    if (cmbIslem.Text == "Röntgen") birimFiyat = 75;

                    cmd.Parameters.AddWithValue("@miktar", miktar);
                    cmd.Parameters.AddWithValue("@fiyat", birimFiyat);
                    cmd.Parameters.AddWithValue("@sira", txtSiraNo.Text);
                    cmd.Parameters.AddWithValue("@toplam", miktar * birimFiyat);
                    cmd.Parameters.AddWithValue("@taburcu", "Hayır");

                    cmd.ExecuteNonQuery();
                    
                    // Listeyi yenile
                    OncekiIslemleriGetir(txtDosyaNo.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekleme Hatası: " + ex.Message);
                }
            }
        }

        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDosyaNo.Text)) return;

            DialogResult res = MessageBox.Show("Hastayı taburcu etmek istiyor musunuz?", "Taburcu", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        // O hastanın açık sevklerini kapat
                        string query = "UPDATE Sevk SET taburcu = 'Evet' WHERE dosyaNo = @no AND taburcu = 'Hayır'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@no", txtDosyaNo.Text);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Hasta taburcu edildi.");
                        Temizle();
                        dgvIslemler.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Basit bir çıktı tasarımı
            Font baslikFont = new Font("Arial", 14, FontStyle.Bold);
            Font icerikFont = new Font("Arial", 10);
            
            e.Graphics.DrawString("SOHATS - Hasta İşlem Fişi", baslikFont, Brushes.Black, 100, 50);
            e.Graphics.DrawString("Dosya No: " + txtDosyaNo.Text, icerikFont, Brushes.Black, 50, 100);
            e.Graphics.DrawString("Hasta Adı: " + txtAd.Text + " " + txtSoyad.Text, icerikFont, Brushes.Black, 50, 120);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToShortDateString(), icerikFont, Brushes.Black, 50, 140);
            
            e.Graphics.DrawString("Toplam Tutar: " + lblToplamTutar.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 180);
        }

        private void Temizle()
        {
            txtDosyaNo.Clear();
            TemizleHasta();
        }

        private void TemizleHasta()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTcNo.Clear();
            txtDrKod.Clear();
            txtMiktar.Text = "1";
            cmbIslem.SelectedIndex = -1;
            cmbPoliklinik.SelectedIndex = -1;
            lblToplamTutar.Text = "0.00";
        }
    }
}
