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

        private Button seciliButon;

        public void MasaGetir(MasaKati katBilgisi)
        {
            flpLayoutPanel.Controls.Clear();
            var masalar = Context.Masalar.Where(m => m.KatBilgisi == katBilgisi).ToList();

            foreach (var masa in masalar)
            {
                Button btn = new Button
                {
                    Text = masa.MasaAdi,
                    Name = "btn" + masa.MasaAdi,
                    Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(100, 100),
                };

                if (masa.Siparisler != null && masa.Siparisler.Count > 0)
                {
                    masa.DoluMu = true;
                    btn.BackColor = doluRenk;
                }
                else
                {
                    btn.BackColor = bosRenk;
                }

                btn.Click += (sender, e) =>
                {
                    seciliButon = sender as Button;
                    //Renklendir(seciliButon);

                    FrmMenu frmmenu = new FrmMenu();
                    frmmenu.masa = masa;
                    
                    if(frmmenu.ShowDialog(this) == DialogResult.OK)
                    {
                        if (SeciliKategori != null)
                            SeciliKategori.PerformClick();
                    }
                };

                flpLayoutPanel.Controls.Add(btn);
            }
        }

        private Color bosRenk = Color.AliceBlue;
        private Color seciliRenk = Color.Tomato;
        private Color doluRenk = Color.DarkSlateGray;
        private void Renklendir(Button seciliButon)
        {
            foreach (Button item in flpLayoutPanel.Controls)
            {
                if (item.Enabled)
                    item.BackColor = item == seciliButon ? seciliRenk : item.BackColor;
            }
        }
        private void Renklendir()
        {
            foreach (Button item in flpLayoutPanel.Controls)
            {
                item.BackColor = bosRenk;
            }
        }

        private Button SeciliKategori;
        private void FrmFloorSelection_Load(object sender, EventArgs e)
        {
            foreach (var katbilgisi in Context.DataSet.Katlar)
            {
                Button btn = new Button
                {
                    Text = katbilgisi.KatBilgisi,
                    Name = "btn" + katbilgisi.KatBilgisi,
                    Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(125, 125)
                };

                flpKatlar.Controls.Add(btn);

                btn.Click += (sender, args) =>
                {
                    SeciliKategori = btn;
                    MasaGetir(katbilgisi);
                };

            }

        }

        private void flpLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
