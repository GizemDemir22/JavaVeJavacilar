﻿using System;
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
    public partial class frmYoneticiYetkileri : Form
    {
        frmYoneticiGiris frmYoneticiGiris;
        public frmYoneticiYetkileri(frmYoneticiGiris frmYoneticiGiris)
        {
            this.frmYoneticiGiris = frmYoneticiGiris;
            InitializeComponent();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            var f = new FrmKullanicilar();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new frmUrunTurleri();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new frmUrunler();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new frmKatlar();
            f.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var f = new FrmAnaRapor();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.frmYoneticiGiris.Show();
        }
    }
}
