using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmOgrList : Form
    {
        public FrmOgrList()
        {
            InitializeComponent();
        }
       
        private void FrmOgrList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet4.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet4.Ogrenci);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle frm = new FrmOgrDuzenle();
            frm.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.tel = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.dogumTarih = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.ogrBolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();     
            frm.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frm.OdaNo = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            frm.veliAdSoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            frm.veliTel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            frm.adres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            frm.Show();

        }
    }
}
