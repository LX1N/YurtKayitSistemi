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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        public string elektrik, su, dogalgaz, gida, diger, internet, personel, id;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,internet=@p4,Gida=@p5,Personel=@p6, Diger=@p7 where Odemeid=@p8", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", txtElektrik.Text);
                cmd.Parameters.AddWithValue("@p2", txtSu.Text);
                cmd.Parameters.AddWithValue("@p3", txtDogalGaz.Text);
                cmd.Parameters.AddWithValue("@p4", txtInternet.Text);
                cmd.Parameters.AddWithValue("@p5", txtGida.Text);
                cmd.Parameters.AddWithValue("@p6", txtPersonel.Text);
                cmd.Parameters.AddWithValue("@p7", txtDiger.Text);
                cmd.Parameters.AddWithValue("@p8", txtId.Text);
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Giderler listesi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmGiderGuncelle.ActiveForm.Close();
                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Giderler listesi güncellenirken bir hata meydana geldi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtId.Text = id;
            txtElektrik.Text = elektrik;
            txtGida.Text = gida;
            txtSu.Text = su;
            txtPersonel.Text = personel;
            txtInternet.Text = internet;
            txtDogalGaz.Text = dogalgaz;
            txtDiger.Text = diger;
        }
    }
}
