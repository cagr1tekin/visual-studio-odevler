using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class frmDosyaBul : Form
    {
        // Seçilen dosya numarasını ana forma (veya çağıran forma) döndürmek için property
        public string SecilenDosyaNo { get; private set; }

        public frmDosyaBul()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            // İsim veya Soyisim veya TC ile arama yapalım
            string kriter = txtAra.Text.Trim();
            
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    // DosyaNo, Ad, Soyad, TCNo gibi alanlarda arama
                    string query = "SELECT dosyaNo, ad, soyad, tcNo, kurumAdi FROM Hasta " +
                                   "WHERE ad LIKE @kriter OR soyad LIKE @kriter OR tcNo LIKE @kriter";
                    
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@kriter", "%" + kriter + "%");
                    
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    dgvSonuclar.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arama Hatası: " + ex.Message);
                }
            }
        }

        // DataGridView'de bir satıra çift tıklandığında seçimi yapıp formu kapatalım
        private void dgvSonuclar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Seçilen satırdaki dosyaNo'yu al
                SecilenDosyaNo = dgvSonuclar.Rows[e.RowIndex].Cells["dosyaNo"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
