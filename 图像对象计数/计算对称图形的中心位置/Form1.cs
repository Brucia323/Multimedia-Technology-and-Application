using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算对称图形的中心位置
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 计算对称图形的中心位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap("C:\\Users\\ZZZCNY\\Documents\\GitHub\\Multimedia-Technology-and-Application\\图像对象计数\\计算对称图形的中心位置\\1.bmp");
            Color color = new Color();
            int minx, miny, maxx, maxy;
            minx = miny = maxx = maxy = 0;
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    color = bitmap.GetPixel(x, y);
                    if (color.R == 0 && color.G == 0 && color.B == 0)
                    {
                        if (minx == 0 && miny == 0 && maxx == 0 && maxy == 0)
                        {
                            minx = maxx = x;
                            miny = maxy = y;
                            continue;
                        }
                        if (x > maxx)
                        {
                            maxx = x;
                        }
                        if (y > maxy)
                        {
                            maxy = y;
                        }
                    }
                }
            }
            int centerx=(maxx - minx)/2;
            int centery=(maxy - miny)/2;
            int s=(maxx-minx)*(maxy-minx);
            label1.Text = "中心点在(" + centerx + "," + centery + ")";
            label1.Text += " 面积是: " + s;
        }
    }
}
