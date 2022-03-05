using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmYoneticiIslemleri : Form
    {
        public FrmYoneticiIslemleri()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmYoneticiIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet6.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Admin (YoneticiAd,YoneticiSifre) values (@p1,@p2)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni yönetici kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);

            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Yeni yönetici kaydedilirken bir hata meydana geldi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, sifre;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtYoneticiID.Text = id;
            txtKullaniciAdi.Text = ad;
            txtSifre.Text = sifre;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from Admin where YoneticiID = @p1",bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtYoneticiID.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yönetici silme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Yönetici silme işlemi gerçekleştirilemedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("update Admin set YoneticiAd=@p1,YoneticiSifre=@p2 where YoneticiID=@p3", bgl.baglanti());
                cmd1.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                cmd1.Parameters.AddWithValue("@p2", txtSifre.Text);
                cmd1.Parameters.AddWithValue("@p3", txtYoneticiID.Text);
                cmd1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yönetici güncelleme işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Yönetici güncelleme işlemi gerçekleştirilirken bir hata meydana geldi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
