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
    public partial class AnaRapor : Form
    {
        public AnaRapor()
        {
            InitializeComponent();
        }

        private void btnGunlukRapor_Click(object sender, EventArgs e)
        {
            frmGunlukRapor frmGunlukRapor = new frmGunlukRapor();
            frmGunlukRapor.Show();
        }

        private void btnAylıkRapor_Click(object sender, EventArgs e)
        {
            frmAylikRapor frmAylikRapor = new frmAylikRapor();
            frmAylikRapor.Show();
        }
    }
}
