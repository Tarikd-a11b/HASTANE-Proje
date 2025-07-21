using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class frmGiriş : Form
    {
        public frmGiriş()
        {
            InitializeComponent();
        }

      

        private void btnhastagiris_Click(object sender, EventArgs e)
        {
            frmHastaGiriş frm = new frmHastaGiriş();
            frm.Show();
            this.Hide();
        }

        private void btndoktorgiris_Click(object sender, EventArgs e)
        {
            frmDoktorGiriş frm = new frmDoktorGiriş();
            frm.Show();
            this.Hide();

        }

        private void btnsekretergiris_Click(object sender, EventArgs e)
        {
            FrmSekreter frm = new FrmSekreter();
            frm.Show();
            this.Hide();

        }

        private void frmGiriş_Load(object sender, EventArgs e)
        {
            
        }
    }
}
