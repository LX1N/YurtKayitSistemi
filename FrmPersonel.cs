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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet7.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into personel (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtPersonelGorev.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Personel);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Personel eklenirken bir hata meydana geldi!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, adSoyad, departman;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adSoyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            departman = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtPersonelID.Text = id;
            txtPersonelAd.Text = adSoyad;
            txtPersonelGorev.Text = departman;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("delete from Personel where Personelid=@p1", bgl.baglanti());
                cmd1.Parameters.AddWithValue("@p1", txtPersonelID.Text);
                cmd1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Personel);
            }
            catch (Exception)
            {
                MessageBox.Show("Personel silinirken bir hata meydana geldi!.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("update Personel set PersonelAdSoyad = @p1,PersonelDepartman = @p2 where Personelid = @p3", bgl.baglanti());
                cmd2.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                cmd2.Parameters.AddWithValue("@p2", txtPersonelGorev.Text);
                cmd2.Parameters.AddWithValue("@p3", txtPersonelID.Text);
                cmd2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet7.Personel);

            }
            catch (Exception)
            {
                MessageBox.Show("Personel güncellenirken bir hata meydana geldi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

        }
    }
    }
