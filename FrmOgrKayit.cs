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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            //Bölümleri Listeleme Komutları
            
            
            SqlCommand komut = new SqlCommand("SELECT BolumAd FROM Bolumler",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbxOgrBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Boş Odaları Listeleme
            
            SqlCommand komut2 = new SqlCommand("SELECT OdaNo FROM Odalar WHERE OdaKapasite!= OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cbxOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
            
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOgrAd.Text=="")
            {
                MessageBox.Show("Öğrenci adı boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtOgrSoyad.Text=="")
            {
                MessageBox.Show("Öğrenci soyadı boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MskOgrTc.Text.Length!=11)
            {
                MessageBox.Show("Öğrenci TC boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MskOgrTel.Text.Length!=14)
            {
                MessageBox.Show("Öğrenci Telefonu boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MskOgrDogumTarih.Text.Length!=10)
            {
                MessageBox.Show("Öğrenci doğum tarihi boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxOgrBolum.Text=="")
            {
                MessageBox.Show("Öğrenci bölümü boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMail.Text=="")
            {
                MessageBox.Show("Öğrenci maili boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbxOdaNo.Text=="")
            {
                MessageBox.Show("Öğrenci oda no boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtVeliAdSoyad.Text=="")
            {
                MessageBox.Show("Öğrenci veli ad soyad boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MskVeliTel.Text.Length== 14) 
            {
                MessageBox.Show("Öğrenci veli telefonu boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAdres.Text=="")
            {
                MessageBox.Show("Öğrenci veli adresi boş geçilemez!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    SqlCommand komutKaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                    komutKaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                    komutKaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                    komutKaydet.Parameters.AddWithValue("@p3", MskOgrTc.Text);
                    komutKaydet.Parameters.AddWithValue("@p4", MskOgrTel.Text);
                    komutKaydet.Parameters.AddWithValue("@p5", MskOgrDogumTarih.Text);
                    komutKaydet.Parameters.AddWithValue("@p6", cbxOgrBolum.Text);
                    komutKaydet.Parameters.AddWithValue("@p7", txtMail.Text);
                    komutKaydet.Parameters.AddWithValue("@p8", cbxOdaNo.Text);
                    komutKaydet.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
                    komutKaydet.Parameters.AddWithValue("@p10", MskVeliTel.Text);
                    komutKaydet.Parameters.AddWithValue("@p11", txtAdres.Text);
                    komutKaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kaydetme Başarılı!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);




                    //Ogrid çekme
                    SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        label3.Text = oku[0].ToString();

                    }
                    bgl.baglanti().Close();


                    //Borçlara kaydetme
                    SqlCommand komut2 = new SqlCommand("insert into Borclar(Ogrid,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@b1", label3.Text);
                    komut2.Parameters.AddWithValue("@b2", txtOgrAd.Text);
                    komut2.Parameters.AddWithValue("@b3", txtOgrSoyad.Text);
                    komut2.ExecuteNonQuery();
                    bgl.baglanti().Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydetme Başarısız!", "KAYIT BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
                //Odanın Aktif Öğrenci Sayısınızı Azaltma
                SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif= OdaAktif+1 where OdaNo=@p1", bgl.baglanti());
                komutoda.Parameters.AddWithValue("@p1", cbxOdaNo.Text);
                komutoda.ExecuteNonQuery();
                bgl.baglanti().Close();


            }
        }
           

        private void gbxOgrenci_Enter(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-OBFEJ5I\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True