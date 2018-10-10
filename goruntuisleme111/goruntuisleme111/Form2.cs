using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goruntuisleme111
{
    public partial class Form2 : Form
    {
        Bitmap kaynak;
        public Form2()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }

        private void renkAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Xkor.Text);
            int y = int.Parse(Ykor.Text);
            Color renk = kaynak.GetPixel(x, y);
            pictureBox2.BackColor = renk;
            Console.WriteLine("R: " + renk.R + "G: " + renk.G + "B: " + renk.B);
        }
    }
}
