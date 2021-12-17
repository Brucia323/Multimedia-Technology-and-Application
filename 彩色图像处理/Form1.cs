using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 彩色图像处理
{
    public partial class Form1 : Form
    {
        Point start, end;
        bool mDown = false;
        Rectangle rect;
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mDown)
            {
                if (e.Button == MouseButtons.Left)
                {
                    end = e.Location;
                    rect.Location = new Point(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y));
                    rect.Size = new Size(Math.Abs(start.X - end.X), Math.Abs(start.Y - end.Y));
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mDown = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (mDown)
            {
                if (pictureBox1.Image != null)
                {
                    if (rect != null && rect.Width > 0 && rect.Height > 0)
                    {
                        e.Graphics.DrawRectangle(new Pen(Color.Black), rect);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int N = 5;
            int r = 0, g = 0, b = 0;
            Color color;
            for (int y = start.Y; y < end.Y; y++)
            {
                for (int x = start.X; x < end.X; x++)
                {
                    if (y == start.Y && x == start.X)
                    {
                        color = bmp.GetPixel(x, y);
                        r = color.R;
                        g = color.G;
                        b = color.B;
                    }
                    else if (x == start.X)
                    {
                        if (y % N == 0)
                        {
                            color = bmp.GetPixel(x, y);
                            r = color.R;
                            g = color.G;
                            b = color.B;
                        }
                    }
                    else if (y % N == 0 || y == start.Y)
                    {
                        if (x % N == 0)
                        {
                            color = bmp.GetPixel(x, y);
                            r = color.R;
                            g = color.G;
                            b = color.B;
                        }
                        else
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                        }
                    }
                    else
                    {
                        Color color1 = bmp.GetPixel(x, y - 1);
                        bmp.SetPixel(x, y, color1);
                    }
                }
            }
            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap("C:\\Users\\ZZZCNY\\Documents\\GitHub\\Multimedia-Technology-and-Application\\彩色图像处理\\image\\RE4wqHB.jpg");
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int height = rect.Height;
            int width = rect.Width;
            Bitmap bitmap = new Bitmap(width, height);
            Color pixel1, pixel2;
            for (int x = start.X; x < end.X - 1; x++)
            {
                for (int y = start.Y; y < end.Y - 1; y++)
                {
                    int r = 0, g = 0, b = 0;
                    pixel1 = bmp.GetPixel(x, y);
                    pixel2 = bmp.GetPixel(x + 1, y + 1);
                    r = Math.Abs(pixel1.R - pixel2.R + 128);
                    g = Math.Abs(pixel1.G - pixel2.G + 128);
                    b = Math.Abs(pixel1.B - pixel2.B + 128);
                    if (r > 255)
                    {
                        r = 255;
                    }
                    if (g > 255)
                    {
                        g = 255;
                    }
                    if (b > 255)
                    {
                        b = 255;
                    }
                    if (r < 0)
                    {
                        r = 0;
                    }
                    if (g < 0)
                    {
                        g = 0;
                    }
                    if (b < 0)
                    {
                        b = 0;
                    }
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            Invalidate();
            mDown = true;
        }
    }
}
