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

namespace Proje_Hastane
{
  

    public partial class FrmBilgiDüzenle : Form
    {
        public string Tcno { get; set; }

        sqlbaglanti bgl = new sqlbaglanti();
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTcKimlikNo.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTcKimlikNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTelefon.Text = dr[4].ToString();
                mskSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

        }

       

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kommut2 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
            kommut2.Parameters.AddWithValue("@p1", textBox1.Text);
            kommut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            kommut2.Parameters.AddWithValue("@p3", mskTelefon.Text);
            kommut2.Parameters.AddWithValue("@p4", mskSifre.Text);
            kommut2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            kommut2.Parameters.AddWithValue("@p6", mskTcKimlikNo.Text);
            kommut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
