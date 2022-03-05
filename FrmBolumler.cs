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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void imgAdd_MouseHover(object sender, EventArgs e)
        {
            imgAdd.BackColor = SystemColors.ControlLight;
        }

        private void imgAdd_MouseLeave(object sender, EventArgs e)
        {
            imgAdd.BackColor = SystemColors.Control;
        }

        private void imgDelete_MouseHover(object sender, EventArgs e)
        {
            imgDelete.BackColor = SystemColors.ControlLight;
        }

        private void imgDelete_MouseLeave(object sender, EventArgs e)
        {
            imgDelete.BackColor = SystemColors.Control;
        }

        private void imgEdit_MouseHover(object sender, EventArgs e)
        {
            imgEdit.BackColor = SystemColors.ControlLight;
        }

        private void imgEdit_MouseLeave(object sender, EventArgs e)
        {
            imgEdit.BackColor = SystemColors.Control;
        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
           //  TODO: This line of code loads data into the 'yurtOtomasyonuDataSet1.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Bolumler);

        }

        private void imgAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm başarıyla eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Bolumler);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Bölüm eklenirken bir hata oluştu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void imgDelete_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Bolumler);
                txtBolumAd.Text = "";
                txtBolumId.Text = "";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Bölüm silinirken bir hata oluştu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, bolumad;

            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtBolumAd.Text = bolumad;
            txtBolumId.Text = id;

        }

        private void imgEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("update Bolumler SET BolumAd = @p1 where Bolumid = @p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("p2", txtBolumId.Text);
                komut2.Parameters.AddWithValue("p1", txtBolumAd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm adı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Bolumler);
                txtBolumAd.Text = "";
                txtBolumId.Text = "";
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Bölüm adı güncellenirken bir hata oluştu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            


        }
    }
}
