using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaVeJavacilar.Forms
{
    public partial class frmYoneticiMiGarsonMi : Form
    {
        frmYoneticiGiris frm;
        public frmYoneticiMiGarsonMi()
        {
            InitializeComponent();
            frm = new frmYoneticiGiris(this);
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void btnGarson_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form f = new FrmWaiterLogin();

            f.Show();
        }

        private void frmYoneticiMiGarsonMi_Load(object sender, EventArgs e)
        {

        }
    }
}
