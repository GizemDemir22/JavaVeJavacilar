﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaVeJavacilar.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
       
        private void btnCorba_Click(object sender, EventArgs e)
        {
            flowLayoutMenu.Controls.Clear();
            //for (int i = 1; i <= int.Parse(Tag.ToString()); i++)
            //{
            //    Button btn = new Button
            //    {
            //        Text = masa.Prefix + i.ToString(),
            //        Name = "btn" + masa.Prefix + i.ToString(),
            //        Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
            //        Size = new Size(150, 150)
            //    };
            //    btn.Click += btnMasa_Click;
            //    flpLayoutPanel.Controls.Add(btn);
            //}
        }

        private void flowLayoutMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //FileStream fileStream = new FileStream("C:\\Users\\Admin\\Source\\Repos\\JavaVeJavacilar\\JavaVeJavacilar\\Resources\\", FileMode.Open);
            //StreamReader reader = new StreamReader(fileStream);
            //string dosyaIcerigi = reader.ReadToEnd();
            //Menuler = JsonConvert.DeserializeObject<List<Menu>>(dosyaIcerigi);
            //foreach (var item in Menuler)
            //{
            //    this.Text = item.Tatlilar;
            //}
        }
    }
}
