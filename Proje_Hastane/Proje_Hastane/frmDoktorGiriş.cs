﻿using System;
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
    public partial class frmDoktorGiriş : Form
    {
        public frmDoktorGiriş()
        {
            InitializeComponent();
        }

        sqlbaglanti sqlbaglanti = new sqlbaglanti();

        private void btnGiriSYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2", sqlbaglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", mskSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmDoktorDetay fr = new frmDoktorDetay();
                fr.TC = msktc.Text;
                
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            sqlbaglanti.baglanti().Close();
        }

        private void frmDoktorGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
