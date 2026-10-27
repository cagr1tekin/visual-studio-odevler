using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmPoliklinik : Form
    {
        public frmPoliklinik()
        {
            InitializeComponent();
        }

        private void frmPoliklinik_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler (varsa)
        }

        // Poliklinik Adı textbox'ında Enter'a basılınca çalışacak
        private void txtPoliklinikAd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ad = txtPoliklinikAd.Text.Trim();
                if (!string.IsNullOrEmpty(ad))
                {
                    PoliklinikAra(ad);
                }
            }
        }

        private void PoliklinikAra(string poliklinikAd)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Poliklinik WHERE poliklinikAd = @ad";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", poliklinikAd);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                // Kayıt bulundu, bilgileri doldur
                                txtAciklama.Text = dr["aciklama"].ToString();
                                // Durum kontrolü (Geçerli/Geçersiz)
                                string durum = dr["durum"].ToString();
                                chkGecerli.Checked = (durum == "Geçerli");
                                
                                btnKaydet.Enabled = false; // Var olan kayıt, güncelleme yapılabilir
                                btnGuncelle.Enabled = true;
                                btnSil.Enabled = true;
                            }
                            else
                            {
                                // Kayıt bulunamadı
                                DialogResult res = MessageBox.Show("Poliklinik bulunamadı. Yeni kayıt açmak ister misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (res == DialogResult.Yes)
                                {
                                    // Adı silme, diğer alanları temizle
                                    Temizle(false); 
                                    btnKaydet.Enabled = true;
                                    btnGuncelle.Enabled = false;
                                    btnSil.Enabled = false;
                                    txtAciklama.Focus();
                                }
                                else
                                {
                                    Temizle(true);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Poliklinik (poliklinikAd, durum, aciklama) VALUES (@ad, @durum, @aciklama)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtPoliklinikAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@durum", chkGecerli.Checked ? "Geçerli" : "Geçersiz");
                        cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text.Trim());
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Poliklinik kaydedildi.");
                        Temizle(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydetme Hatası: " + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
             using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Poliklinik SET durum = @durum, aciklama = @aciklama WHERE poliklinikAd = @ad";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtPoliklinikAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@durum", chkGecerli.Checked ? "Geçerli" : "Geçersiz");
                        cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text.Trim());
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Poliklinik güncellendi.");
                        Temizle(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme Hatası: " + ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bu polikliniği silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Poliklinik WHERE poliklinikAd = @ad";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", txtPoliklinikAd.Text.Trim());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Poliklinik silindi.");
                            Temizle(true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme Hatası: " + ex.Message);
                    }
                }
            }
        }

        private void Temizle(bool adSil)
        {
            if (adSil) txtPoliklinikAd.Clear();
            txtAciklama.Clear();
            chkGecerli.Checked = false;
            btnKaydet.Enabled = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
    }
}
