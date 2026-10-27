using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmKullanici : Form
    {
        // Kullanıcı güncelleme/silme işlemleri için seçilen kullanıcının ID'sini tutalım
        private int _secilenKullaniciKod = 0;

        public frmKullanici()
        {
            InitializeComponent();
        }

        // Kullanıcıları listelemek için bir metot (Örn: Form Load'da veya işlem sonrası çağrılabilir)
        // Bu örnekte DataGridView (dgvKullanicilar) olduğunu varsayıyoruz.
        private void KullanicilariListele()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kullanicilar", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // dgvKullanicilar.DataSource = dt; // Tasarımda DataGridView varsa
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme Hatası: " + ex.Message);
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
                    string query = "INSERT INTO Kullanicilar (kullaniciAd, sifre, yetki) VALUES (@ad, @sifre, @yetki)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtKullaniciAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
                        cmd.Parameters.AddWithValue("@yetki", cmbYetki.Text); // admin veya personel
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı eklendi.");
                        Temizle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekleme Hatası: " + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenKullaniciKod == 0)
            {
                // Basitlik için, eğer kullanıcı adı varsa onu güncellemeye çalışalım (ID olmadan)
                // Veya kullanıcıdan önce seçim yapmasını isteyebiliriz.
                // Bu örnekte ID takibi yapmadığımız için (Listeleme yok), sadece isimden güncelleme deneyelim.
                // Ancak doğru olan ID ile güncellemektir.
                MessageBox.Show("Lütfen güncellenecek kullanıcıyı seçiniz (Listeleme özelliği eklenmeli).");
                return;
            }

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Kullanicilar SET kullaniciAd = @ad, sifre = @sifre, yetki = @yetki WHERE kullaniciKod = @kod";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtKullaniciAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
                        cmd.Parameters.AddWithValue("@yetki", cmbYetki.Text);
                        cmd.Parameters.AddWithValue("@kod", _secilenKullaniciKod);
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı güncellendi.");
                        Temizle();
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
            if (_secilenKullaniciKod == 0)
            {
                 // Basitlik için isimden silme yapalım (ID yoksa)
                 // Gerçek projede ID kullanılmalı.
                 if(string.IsNullOrEmpty(txtKullaniciAd.Text)) {
                    MessageBox.Show("Lütfen silinecek kullanıcı adını giriniz.");
                    return;
                 }
            }

            DialogResult res = MessageBox.Show("Kullanıcıyı silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        // ID varsa ID'den, yoksa Ad'dan sil (Örnek amaçlı)
                        string query = _secilenKullaniciKod > 0 ? "DELETE FROM Kullanicilar WHERE kullaniciKod = @kod" : "DELETE FROM Kullanicilar WHERE kullaniciAd = @ad";
                        
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            if(_secilenKullaniciKod > 0)
                                cmd.Parameters.AddWithValue("@kod", _secilenKullaniciKod);
                            else
                                cmd.Parameters.AddWithValue("@ad", txtKullaniciAd.Text.Trim());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Kullanıcı silindi.");
                            Temizle();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme Hatası: " + ex.Message);
                    }
                }
            }
        }

        private void Temizle()
        {
            txtKullaniciAd.Clear();
            txtSifre.Clear();
            cmbYetki.SelectedIndex = -1;
            _secilenKullaniciKod = 0;
            // KullanicilariListele(); // Listeyi yenile
        }
    }
}
