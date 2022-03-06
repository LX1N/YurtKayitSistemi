
namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskOgrTc = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrTel = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.MskOgrDogumTarih = new System.Windows.Forms.MaskedTextBox();
            this.lblDogumTarih = new System.Windows.Forms.Label();
            this.lblOgrBolum = new System.Windows.Forms.Label();
            this.cbxOgrBolum = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.cbxOdaNo = new System.Windows.Forms.ComboBox();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.gbxOgrenci = new System.Windows.Forms.GroupBox();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.lblVeliAdSoyad = new System.Windows.Forms.Label();
            this.MskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.lblVeliTel = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrAd.Location = new System.Drawing.Point(44, 56);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(92, 20);
            this.lblOgrAd.TabIndex = 0;
            this.lblOgrAd.Text = "Ögrenci Ad:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAd.Location = new System.Drawing.Point(142, 50);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(203, 26);
            this.txtOgrAd.TabIndex = 1;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrSoyad.Location = new System.Drawing.Point(142, 84);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(203, 26);
            this.txtOgrSoyad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ögrenci Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "T.C. No:";
            // 
            // MskOgrTc
            // 
            this.MskOgrTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTc.Location = new System.Drawing.Point(142, 118);
            this.MskOgrTc.Mask = "00000000000";
            this.MskOgrTc.Name = "MskOgrTc";
            this.MskOgrTc.Size = new System.Drawing.Size(203, 26);
            this.MskOgrTc.TabIndex = 5;
            this.MskOgrTc.ValidatingType = typeof(int);
            // 
            // MskOgrTel
            // 
            this.MskOgrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrTel.Location = new System.Drawing.Point(142, 153);
            this.MskOgrTel.Mask = "(999) 000-0000";
            this.MskOgrTel.Name = "MskOgrTel";
            this.MskOgrTel.Size = new System.Drawing.Size(203, 26);
            this.MskOgrTel.TabIndex = 7;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(71, 159);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(66, 20);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Telefon:";
            // 
            // MskOgrDogumTarih
            // 
            this.MskOgrDogumTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOgrDogumTarih.Location = new System.Drawing.Point(142, 187);
            this.MskOgrDogumTarih.Mask = "00/00/0000";
            this.MskOgrDogumTarih.Name = "MskOgrDogumTarih";
            this.MskOgrDogumTarih.Size = new System.Drawing.Size(203, 26);
            this.MskOgrDogumTarih.TabIndex = 9;
            this.MskOgrDogumTarih.ValidatingType = typeof(System.DateTime);
            // 
            // lblDogumTarih
            // 
            this.lblDogumTarih.AutoSize = true;
            this.lblDogumTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarih.Location = new System.Drawing.Point(29, 194);
            this.lblDogumTarih.Name = "lblDogumTarih";
            this.lblDogumTarih.Size = new System.Drawing.Size(107, 20);
            this.lblDogumTarih.TabIndex = 8;
            this.lblDogumTarih.Text = "Doğum Tarihi:";
            // 
            // lblOgrBolum
            // 
            this.lblOgrBolum.AutoSize = true;
            this.lblOgrBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrBolum.Location = new System.Drawing.Point(19, 230);
            this.lblOgrBolum.Name = "lblOgrBolum";
            this.lblOgrBolum.Size = new System.Drawing.Size(117, 20);
            this.lblOgrBolum.TabIndex = 10;
            this.lblOgrBolum.Text = "Öğrenci Bölüm:";
            // 
            // cbxOgrBolum
            // 
            this.cbxOgrBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxOgrBolum.FormattingEnabled = true;
            this.cbxOgrBolum.Location = new System.Drawing.Point(142, 222);
            this.cbxOgrBolum.Name = "cbxOgrBolum";
            this.cbxOgrBolum.Size = new System.Drawing.Size(203, 28);
            this.cbxOgrBolum.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(142, 258);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(203, 26);
            this.txtMail.TabIndex = 13;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(95, 265);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 20);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail:";
            // 
            // cbxOdaNo
            // 
            this.cbxOdaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxOdaNo.FormattingEnabled = true;
            this.cbxOdaNo.Location = new System.Drawing.Point(142, 293);
            this.cbxOdaNo.Name = "cbxOdaNo";
            this.cbxOdaNo.Size = new System.Drawing.Size(203, 28);
            this.cbxOdaNo.TabIndex = 15;
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaNo.Location = new System.Drawing.Point(19, 302);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(114, 20);
            this.lblOdaNo.TabIndex = 14;
            this.lblOdaNo.Text = "Oda Numarası:";
            // 
            // gbxOgrenci
            // 
            this.gbxOgrenci.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxOgrenci.Location = new System.Drawing.Point(12, 14);
            this.gbxOgrenci.Name = "gbxOgrenci";
            this.gbxOgrenci.Size = new System.Drawing.Size(362, 324);
            this.gbxOgrenci.TabIndex = 16;
            this.gbxOgrenci.TabStop = false;
            this.gbxOgrenci.Text = "Öğrenci Bilgileri";
            this.gbxOgrenci.Enter += new System.EventHandler(this.gbxOgrenci_Enter);
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(142, 402);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(203, 26);
            this.txtVeliAdSoyad.TabIndex = 18;
            // 
            // lblVeliAdSoyad
            // 
            this.lblVeliAdSoyad.AutoSize = true;
            this.lblVeliAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliAdSoyad.Location = new System.Drawing.Point(28, 405);
            this.lblVeliAdSoyad.Name = "lblVeliAdSoyad";
            this.lblVeliAdSoyad.Size = new System.Drawing.Size(112, 20);
            this.lblVeliAdSoyad.TabIndex = 17;
            this.lblVeliAdSoyad.Text = "Veli Ad Soyad:";
            // 
            // MskVeliTel
            // 
            this.MskVeliTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskVeliTel.Location = new System.Drawing.Point(142, 434);
            this.MskVeliTel.Mask = "(999) 000-0000";
            this.MskVeliTel.Name = "MskVeliTel";
            this.MskVeliTel.Size = new System.Drawing.Size(203, 26);
            this.MskVeliTel.TabIndex = 20;
            // 
            // lblVeliTel
            // 
            this.lblVeliTel.AutoSize = true;
            this.lblVeliTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliTel.Location = new System.Drawing.Point(40, 437);
            this.lblVeliTel.Name = "lblVeliTel";
            this.lblVeliTel.Size = new System.Drawing.Size(96, 20);
            this.lblVeliTel.TabIndex = 19;
            this.lblVeliTel.Text = "Veli Telefon:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(142, 466);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(203, 96);
            this.txtAdres.TabIndex = 21;
            this.txtAdres.Text = "";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(81, 464);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(55, 20);
            this.lblAdres.TabIndex = 22;
            this.lblAdres.Text = "Adres:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 214);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veli Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(85, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(386, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.MskVeliTel);
            this.Controls.Add(this.lblVeliTel);
            this.Controls.Add(this.txtVeliAdSoyad);
            this.Controls.Add(this.lblVeliAdSoyad);
            this.Controls.Add(this.cbxOdaNo);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.cbxOgrBolum);
            this.Controls.Add(this.lblOgrBolum);
            this.Controls.Add(this.MskOgrDogumTarih);
            this.Controls.Add(this.lblDogumTarih);
            this.Controls.Add(this.MskOgrTel);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.MskOgrTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.lblOgrAd);
            this.Controls.Add(this.gbxOgrenci);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskOgrTc;
        private System.Windows.Forms.MaskedTextBox MskOgrTel;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox MskOgrDogumTarih;
        private System.Windows.Forms.Label lblDogumTarih;
        private System.Windows.Forms.Label lblOgrBolum;
        private System.Windows.Forms.ComboBox cbxOgrBolum;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ComboBox cbxOdaNo;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.GroupBox gbxOgrenci;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.Label lblVeliAdSoyad;
        private System.Windows.Forms.MaskedTextBox MskVeliTel;
        private System.Windows.Forms.Label lblVeliTel;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

