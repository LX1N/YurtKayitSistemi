using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        public string id, ad, soyad, TC, tel, dogumTarih, ogrBolum, mail, OdaNo, veliAdSoyad, veliTel, adres;

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Öğrenci silme
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where Ogrid=@k1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1",txtOgrId.Text);
            komutsil.ExecuteReader();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Oda kontenjanı arttırma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif = OdaAktif-1 where OdaNo=@oda",bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda",cbxOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2, OgrSoyad=@p3, OgrTC=@p4, OgrTelefon=@p5,OgrDogum=@p6, OgrBolum=@p7, OgrMail=@p8, OgrOdaNo=@p9, OgrVeliAdSoyad=@p10, OgrVeliTelefon=@p11, OgrVeliAdres=@p12 where Ogrid = @p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrId.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskOgrTc.Text);
                komut.Parameters.AddWithValue("@p5", MskOgrTel.Text);
                komut.Parameters.AddWithValue("@p6", MskOgrDogumTarih.Text);
                komut.Parameters.AddWithValue("@p8", txtMail.Text);
                komut.Parameters.AddWithValue("@p7", cbOgrBolum.Text);
                komut.Parameters.AddWithValue("@p9", cbxOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", MskVeliTel.Text);
                komut.Parameters.AddWithValue("@p12", txtAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmOgrDuzenle.ActiveForm.Close();
                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                MessageBox.Show("Kayıt güncellenirken bir hata meydana geldi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtOgrId.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            MskOgrTc.Text = TC;
            MskOgrTel.Text = tel;
            cbOgrBolum.Text = ogrBolum;
            MskOgrDogumTarih.Text = dogumTarih;
            txtMail.Text = mail;
            cbxOdaNo.Text = OdaNo;
            txtVeliAdSoyad.Text = veliAdSoyad;
            MskVeliTel.Text = veliTel;
            txtAdres.Text = adres;
        }
    }
}
