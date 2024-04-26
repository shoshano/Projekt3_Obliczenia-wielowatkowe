using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Projekt3_Obliczenia_wielowątkowe
{
    public partial class FormImage : Form
    {
        private Bitmap? img;
        private Bitmap? ThrImg;
        private Bitmap? MirrorImg;
        private Bitmap? NegImg;
        private Bitmap? GrayImg;

        private Thread[] threads;

        public FormImage()
        {
            InitializeComponent();
            threads = new Thread[4];
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                img = new Bitmap(file);
                pictureBoxOrginal.Image = img;
            }
        }

        private void Thresholding()
        {
                        
            double avgBright = 0;
            for (int y = 0; y < ThrImg.Height; y++)
            {
                for (int x = 0; x < ThrImg.Width; x++)
                {
                    avgBright += ThrImg.GetPixel(x, y).GetBrightness();
                }
            }
            avgBright = avgBright / (ThrImg.Width * ThrImg.Height);
            avgBright = avgBright < .3 ? .3 : avgBright;
            avgBright = avgBright > .7 ? .7 : avgBright;

            for (int y = 0; y < ThrImg.Height; y++)
            {
                for (int x = 0; x < ThrImg.Width; x++)
                {
                    if (ThrImg.GetPixel(x, y).GetBrightness() > avgBright) ThrImg.SetPixel(x, y, Color.White);
                    else ThrImg.SetPixel(x, y, Color.Black);
                }
            }
            
            pictureBox1.Image = ThrImg;
        }

        private void GrayScale()
        {
            
            for (int i = 0; i < GrayImg.Width; i++)
            {
                for (int j = 0; j < GrayImg.Height; j++)
                {
                    Color originalColor = GrayImg.GetPixel(i, j);

                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));

                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);

                    GrayImg.SetPixel(i, j, newColor);
                }
            }
            pictureBox2.Image = GrayImg;
        }

        private void MirrorRotation()
        {
            Bitmap orginal;
            orginal = (Bitmap)img.Clone();

            for (int y = 0; y < MirrorImg.Height; y++)
            {
                for (int lx = 0, rx = MirrorImg.Width - 1; lx < MirrorImg.Width; lx++, rx--)
                {
                    Color p = orginal.GetPixel(lx, y);

                    MirrorImg.SetPixel(rx, y, p);
                }
            }

            pictureBox3.Image = MirrorImg;

        }

        private void Negative()
        {
           
            for (int y = 0; y < NegImg.Height; y++)
            {
                for (int x = 0; x < NegImg.Width; x++)
                {
                    Color p = NegImg.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    NegImg.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox4.Image = NegImg;
        }

        private void buttonFillter_Click(object sender, EventArgs e)
        {
            ThrImg = (Bitmap)img.Clone();
            MirrorImg = (Bitmap)img.Clone();
            NegImg = (Bitmap)img.Clone();
            GrayImg = (Bitmap)img.Clone();
            ParallelOptions parallelOptions = new ParallelOptions() { MaxDegreeOfParallelism = 4 };
            Parallel.For(0, 4, parallelOptions, x =>
            {
                switch (x)
                {
                    case 0: { Thresholding(); break; }
                    case 1: { GrayScale(); break;}
                    case 2: { MirrorRotation(); break;}
                    case 3: { Negative(); break;}
                }
            });
        }
    }
}
