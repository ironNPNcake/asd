using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        //69 64
        Bitmap mapa;
        Point punkt;
        Bitmap original;
        public Form1()
        {
            InitializeComponent();
            mapa = new Bitmap("mapa.bmp");
            pictureBox1.Image = mapa;
            punkt = new Point(91, 61);
            original = new Bitmap("mapa.bmp");
        }
        private void narysuj_cos()
        {
            mapa.SetPixel(punkt.X, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X + 1, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X + 2, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X + 3, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X - 1, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X - 2, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X - 3, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y + 1, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y + 2, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y + 3, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y - 1, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y - 2, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y - 3, Color.Red);
            //mapa.SetPixel(punkt.X + 5, punkt.Y, Color.Red);
            pictureBox1.Image = mapa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            narysuj_cos();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mapa = original;

            if (mapa.GetPixel(punkt.X + 1 , punkt.Y).R == 0)
            {   //1
                mapa = original;
                punkt.X = punkt.X + 1 ;
                MessageBox.Show("ASDasdasd");
            }
            else if (mapa.GetPixel(punkt.X + 1, punkt.Y + 1).R == 0 && mapa.GetPixel(punkt.X + 1, punkt.Y + 1).G == 0 && mapa.GetPixel(punkt.X + 1, punkt.Y + 1).B == 0)
            {   //2
                mapa = original;
                punkt.X = punkt.X + 1;
                punkt.Y = punkt.Y + 1;
            }
            else if (mapa.GetPixel(punkt.X, punkt.Y + 1).R == 0 && mapa.GetPixel(punkt.X, punkt.Y + 1).G == 0 && mapa.GetPixel(punkt.X, punkt.Y + 1).B == 0)
            {   //3
                mapa = original;
                punkt.X = punkt.X;
                punkt.Y = punkt.Y + 1;
            }
            else if (mapa.GetPixel(punkt.X - 1, punkt.Y + 1).R == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y + 1).G == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y + 1).B == 0)
            {   //4
                mapa = original;
                punkt.X = punkt.X - 1;
                punkt.Y = punkt.Y + 1;
            }
            else if (mapa.GetPixel(punkt.X - 1, punkt.Y).R == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y).G == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y).B == 0)
            {   //5
                mapa = original;
                punkt.X = punkt.X - 1;
                punkt.Y = punkt.Y;
            }
            else if (mapa.GetPixel(punkt.X - 1, punkt.Y - 1).R == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y - 1).G == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y - 1).B == 0)
            {   //6
                mapa = original;
                punkt.X = punkt.X - 1;
                punkt.Y = punkt.Y - 1;
            }
            else if (mapa.GetPixel(punkt.X, punkt.Y - 1).R == 0 && mapa.GetPixel(punkt.X, punkt.Y - 1).B == 0 && mapa.GetPixel(punkt.X, punkt.Y - 1).G == 0)
            {   //7
                mapa = original;
                punkt.X = punkt.X;
                punkt.Y = punkt.Y - 1;
            }
            else if (mapa.GetPixel(punkt.X + 1, punkt.Y - 1).R == 0 && mapa.GetPixel(punkt.X + 1, punkt.Y - 1).G == 0 && mapa.GetPixel(punkt.X + 1, punkt.Y - 1).B == 0)
            {   //8
                mapa = original;
                punkt.X = punkt.X + 1;
                punkt.Y = punkt.Y - 1;
            }
            else MessageBox.Show("asd");
          //  MessageBox.Show("hello");
            narysuj_cos();
          /*  mapa = original;
            pictureBox1.Image = mapa;
            Color pixelcolor = mapa.GetPixel(0, 0);
            MessageBox.Show(pixelcolor.ToString());
           /* if (mapa.GetPixel(0, 0).R == 255&&)
                MessageBox.Show("hello");*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            punkt.X = Convert.ToInt16(textBox1.Text);
            punkt.Y = Convert.ToInt16(textBox2.Text );
            label1.Text = mapa.GetPixel(punkt.X, punkt.Y).R + " "+mapa.GetPixel(punkt.X, punkt.Y).G + " "+mapa.GetPixel(punkt.X, punkt.Y).B + " ";
        }
    }
}