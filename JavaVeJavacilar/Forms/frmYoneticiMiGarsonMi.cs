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
        frmYoneticiGiris frmYoneticiGiris;
        FrmWaiterLogin frmWaiterLogin;
        public frmYoneticiMiGarsonMi()
        {
            InitializeComponent();
            frmYoneticiGiris = new frmYoneticiGiris(this);
            frmWaiterLogin = new FrmWaiterLogin(this);
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYoneticiGiris.Show();
        }

        private void btnGarson_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWaiterLogin.Show();            
        }

        private void frmYoneticiMiGarsonMi_Load(object sender, EventArgs e)
        {

        }
    }
}
