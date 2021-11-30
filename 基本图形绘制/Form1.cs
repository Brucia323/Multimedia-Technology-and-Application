using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 基本图形绘制
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen curPen = new Pen(Brushes.Black, 1);
            g.DrawLine(curPen, 50, 240, 620, 240);
            g.DrawLine(curPen, 50, 240, 50, 30);
            g.DrawLine(curPen, 100, 240, 100, 242);
            g.DrawLine(curPen, 150, 240, 150, 242);
            g.DrawLine(curPen, 200, 240, 200, 242);
            g.DrawLine(curPen, 250, 240, 250, 242);
            g.DrawLine(curPen, 300, 240, 300, 242);
            g.DrawLine(curPen, 350, 240, 350, 242);
            g.DrawLine(curPen, 400, 240, 400, 242);
            g.DrawLine(curPen, 450, 240, 450, 242);
            g.DrawLine(curPen, 500, 240, 500, 242);
            g.DrawLine(curPen, 550, 240, 550, 242);
            g.DrawLine(curPen, 600, 240, 600, 242);
            g.DrawString("概率论", new Font("New Timer", 8), Brushes.Black, new PointF(50, 242));
            g.DrawString("Python", new Font("New Timer", 8), Brushes.Black, new PointF(100, 242));
            g.DrawString("管信", new Font("New Timer", 8), Brushes.Black, new PointF(150, 242));
            g.DrawString("网页", new Font("New Timer", 8), Brushes.Black, new PointF(200, 242));
            g.DrawString("毛概", new Font("New Timer", 8), Brushes.Black, new PointF(250, 242));
            g.DrawString("形政", new Font("New Timer", 8), Brushes.Black, new PointF(300, 242));
            g.DrawString("网球", new Font("New Timer", 8), Brushes.Black, new PointF(350, 242));
            g.DrawString("JAVA", new Font("New Timer", 8), Brushes.Black, new PointF(400, 242));
            g.DrawString("实践", new Font("New Timer", 8), Brushes.Black, new PointF(450, 242));
            g.DrawString("网络", new Font("New Timer", 8), Brushes.Black, new PointF(500, 242));
            g.DrawString("跨文化", new Font("New Timer", 8), Brushes.Black, new PointF(550, 242));
            g.DrawLine(curPen, 48, 40, 50, 40);
            g.DrawLine(curPen, 48, 60, 50, 60);
            g.DrawLine(curPen, 48, 80, 50, 80);
            g.DrawLine(curPen, 48, 100, 50, 100);
            g.DrawLine(curPen, 48, 120, 50, 120);
            g.DrawString("0", new Font("New Timer", 8), Brushes.Black, new PointF(34, 234));
            g.DrawString("60", new Font("New Timer", 8), Brushes.Black, new PointF(34, 114));
            g.DrawString("70", new Font("New Timer", 8), Brushes.Black, new PointF(34, 94));
            g.DrawString("80", new Font("New Timer", 8), Brushes.Black, new PointF(34, 74));
            g.DrawString("90", new Font("New Timer", 8), Brushes.Black, new PointF(34, 54));
            g.DrawString("100", new Font("New Timer", 8), Brushes.Black, new PointF(28, 34));
            int temp = 0;
            int[] vs = new int[] { 67, 96, 83, 90, 85, 91, 87, 83, 85, 81, 67 };
            Random random = new Random();
            int R = random.Next(0, 256);
            int G = random.Next(0, 256);
            int B = random.Next(0, 256);
            for (int i = 0; i < vs.Length; i++)
            {
                Pen pen = new Pen(Color.FromArgb(R, G, B), 50);
                temp = vs[i] * 2;
                g.DrawLine(pen, 75 + 50 * i, 240, 75 + 50 * i, 240 - temp);
                R = random.Next(0, 256);
                G = random.Next(0, 256);
                B = random.Next(0, 256);
            }
        }
    }
}
