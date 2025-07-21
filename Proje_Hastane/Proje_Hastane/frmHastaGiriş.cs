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
    public partial class frmHastaGiriş : Form
    {
        public frmHastaGiriş()
        {
            InitializeComponent();
        }

        sqlbaglanti bglanti = new sqlbaglanti();
        private void lbluyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr = new FrmHastaKayıt();
            fr.Show();
        }

        private void btnGiriSYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select * from Tbl_Hastalar where HastaTc=@p1 and HastaSifre=@p2",bglanti.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTcKimlikNo.Text);
            komut.Parameters.AddWithValue("@p2", mskSifre.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                frmHastaDetay frm = new frmHastaDetay();
                frm.tc = mskTcKimlikNo.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali sifre veya TC");
            }
            bglanti.baglanti().Close();
        }

        private void frmHastaGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
