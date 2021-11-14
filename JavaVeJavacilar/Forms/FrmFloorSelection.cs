using JavaVeJavacilar.Data;
using JavaVeJavacilar.Data.Concrate;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaVeJavacilar.Forms
{
    public partial class FrmFloorSelection : Form
    {
        public FrmFloorSelection()
        {
            InitializeComponent();
        }

        public List<Masa> Masalar;
        private Button seciliButon;

        public void MasaGetir(Masa masa)
        {
            flpLayoutPanel.Controls.Clear();
         
                    for (int i = 1; i <= Context.Masalar.Count; i++)
                {
                    Button btn = new Button
                    {
                        Text = masa.MasaAdi,
                        Name = "btn" + masa.MasaAdi,
                        Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                        Size = new Size(150, 150)
                    };
                btn.Click += btnMasa_Click;
                flpLayoutPanel.Controls.Add(btn);
                }


           
        }

        private void btnMasa_Click(object sender, EventArgs e)
        {

            seciliButon = sender as Button;
            Renklendir(seciliButon);
            FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
        }

        private Color bosRenk = Color.MediumSpringGreen;
        private Color seciliRenk = Color.Tomato;
        private Color doluRenk = Color.DarkSlateGray;
        private void Renklendir(Button seciliButon)
        {
            foreach (Button item in flpLayoutPanel.Controls)
            {
                if (item.Enabled)
                    item.BackColor = item == seciliButon ? seciliRenk : bosRenk;
            }
        }
        private void Renklendir()
        {
            foreach (Button item in flpLayoutPanel.Controls)
            {
                item.BackColor = bosRenk;
            }
        }
  
        private void FrmFloorSelection_Load(object sender, EventArgs e)
        {
            foreach (var masa in Context.DataSet.Katlar)
            {
                Button btn = new Button
                {
                    Text = masa.KatBilgisi,
                    Name = "btn" + masa.KatBilgisi,
                    Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(125, 125)
                };
                btn.Click += btnKat_Click;
                pnlKatlar.Controls.Add(btn);
            }

        }

        private void btnKat_Click(object sender, EventArgs e)
        {
            seciliButon = sender as Button;
        }

        private void btnTerasK_Click(object sender, EventArgs e)
        {

        }
    }
}
