using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goruntuisleme222
{
    public partial class Form2 : Form
    {
        Bitmap kaynak, islem;
        public Form2()
        {
            InitializeComponent();
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            islem = new Bitmap(gen, yuk);
            for(int y=0; y<yuk; y++)
            {
                for(int x=0;x<gen;x++)
                {
                    Color renk = kaynak.GetPixel(x, y);
                    int ortalama = (renk.R + renk.G + renk.B) / 3;
                    Color gri = Color.FromArgb(ortalama, ortalama, ortalama);
                    islem.SetPixel(x, y, gri);
                }
            }
            islemBox.Image = islem;
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK) ;
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }
    }
}
