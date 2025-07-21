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
    public partial class frmHastaDetay : Form
    {

        public frmHastaDetay()
        {
            InitializeComponent();
        }

         public string tc;

        sqlbaglanti bglanti = new sqlbaglanti();
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {

            //ad soyad çekme 
            lblTcNo.Text = tc;

            SqlCommand sqlCommand = new SqlCommand("select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTc=@p1", bglanti.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", lblTcNo.Text);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                lblAdSoyad.Text = dataReader[0] + " " + dataReader[1];
            }
            bglanti.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Tbl_Randevular where HastaTc=" + tc, bglanti.baglanti());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            //
          

            //Branşları Çekme   
            SqlCommand sqlCommand1 = new SqlCommand("select BransAd from Tbl_Branslar", bglanti.baglanti());
            SqlDataReader dataReader1 = sqlCommand1.ExecuteReader();
            while (dataReader1.Read())
            {
                cmbBrans.Items.Add(dataReader1[0]);
            }
            bglanti.baglanti().Close();

            
           

        }

        //Doktorları Çekme

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bglanti.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bglanti.baglanti().Close();

        }

      
        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
           DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans='" + cmbBrans.Text + "'",bglanti.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

           
        }

        private void lnkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = lblTcNo.Text; // Hasta TC bilgisini formun TCno özelliğine atıyoruz
            fr.Show();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        // Diğer using'ler aynı şekilde kaldı

        private void AktifRandevulariListele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT RandevuID, RandevuTarih, RandevuSaat, RandevuDoktor FROM Tbl_Randevular WHERE RandevuBrans = @brans AND RandevuDoktor = @doktor AND RandevuDurum = 0", bgl.baglanti());
                da.SelectCommand.Parameters.AddWithValue("@brans", cmbBrans.Text);
                da.SelectCommand.Parameters.AddWithValue("@doktor", cmbDoktor.Text);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Randevular SET RandevuDurum=1, HastaTc=@p1, HastaSikayet=@p2 WHERE Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTcNo.Text);
            komut.Parameters.AddWithValue("@p2", rchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı","uyari",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }




    }
}
