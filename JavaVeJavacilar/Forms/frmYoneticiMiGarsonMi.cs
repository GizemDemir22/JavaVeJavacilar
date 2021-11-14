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
        public frmYoneticiMiGarsonMi()
        {
            InitializeComponent();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form f = new frmYoneticiGiris();

            f.Show();
        }

        private void btnGarson_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form f = new FrmWaiterLogin();

            f.Show();
        }
    }
}
