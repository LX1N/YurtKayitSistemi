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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet3.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected;
            string id, ad, soyad, kalan;

            selected = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[selected].Cells[3].Value.ToString();

            txtOgrenciID.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            txtKalan.Text = kalan;

        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            // ödenen tutarı kalan tutardan düşme
            int odenen, kalan,yeniBorc;
            odenen = Convert.ToInt16(txtOdenen.Text);
            kalan = Convert.ToInt16(txtKalan.Text);

            yeniBorc = kalan - odenen;
            txtKalan.Text = yeniBorc.ToString();
            // sql e kaydetme

            try
            {
                SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("p1", txtKalan.Text);
                komut.Parameters.AddWithValue("p2", txtOgrenciID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kalan Borç başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Borclar);

                //kasa tablosuna ekleme yapma
                SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy, OdemeMiktar) values (@k1,@k2)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@k1", txtOdenenAy.Text);
                komut2.Parameters.AddWithValue("@k2", txtOdenen.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Kalan Borç güncellenirken bir hata meydana geldi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            



        }
    }
}
