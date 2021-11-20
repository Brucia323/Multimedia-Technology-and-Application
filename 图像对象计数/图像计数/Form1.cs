using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图像计数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 图像计数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap("C:\\Users\\ZZZCNY\\Documents\\GitHub\\Multimedia-Technology-and-Application\\图像对象计数\\图像计数\\1.bmp");
            Color color = new Color();
            int count = 0;
            int[] count1 = { 0 };
            int[,] vs = new int[bitmap.Width, bitmap.Height];
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    color = bitmap.GetPixel(x, y);
                    if (color.R == 0 && color.G == 0 && color.B == 0)
                    {
                        if (x - 1 < 0 || y - 1 < 0 || x + 1 == bitmap.Width || y + 1 == bitmap.Height)
                        {
                            continue;
                        }
                        if (vs[x - 1, y - 1] != 0 || vs[x - 1, y] != 0 || vs[x - 1, y + 1] != 0 || vs[x, y - 1] != 0 || vs[x, y + 1] != 0 || vs[x + 1, y - 1] != 0 || vs[x + 1, y] != 0 || vs[x + 1, y + 1] != 0)
                        {
                            if (vs[x, y] != 0)
                            {
                                continue;
                            }
                            vs[x, y] = 1;
                            if (bitmap.GetPixel(x + 1, y).R == 0)
                            {
                                for (int x1 = x + 1; x1 < bitmap.Width; x1++)
                                {
                                    for (int y1 = y; y1 > 0; y1--)
                                    {
                                        color = bitmap.GetPixel(x1, y1);
                                        if (color.R == 0 && color.G == 0 && color.B == 0)
                                        {
                                            vs[x1, y1] = 1;
                                        }
                                        if (bitmap.GetPixel(x1, y1 - 1).R == 255)
                                        {
                                            break;
                                        }
                                    }
                                    for (int y1 = y; y1 < bitmap.Height; y1++)
                                    {
                                        color = bitmap.GetPixel(x1, y1);
                                        if (color.R == 0 && color.G == 0 && color.B == 0)
                                        {
                                            vs[x1, y1] = 1;
                                        }
                                        if (bitmap.GetPixel(x1, y1 + 1).R == 255)
                                        {
                                            break;
                                        }
                                    }
                                    if (bitmap.GetPixel(x1 + 1, y).R == 255)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (bitmap.GetPixel(x - 1, y).R == 0)
                            {
                                for (int x1 = x - 1; x1 > 0; x1--)
                                {
                                    for (int y1 = y; y1 > 0; y1--)
                                    {
                                        color = bitmap.GetPixel(x1, y1);
                                        if (color.R == 0 && color.G == 0 && color.B == 0)
                                        {
                                            vs[x1, y1] = 1;
                                        }
                                        if (bitmap.GetPixel(x1, y1 - 1).R == 255)
                                        {
                                            break;
                                        }
                                    }
                                    for (int y1 = y; y1 < bitmap.Height; y1++)
                                    {
                                        color = bitmap.GetPixel(x1, y1);
                                        if (color.R == 0 && color.G == 0 && color.B == 0)
                                        {
                                            vs[x1, y1] = 1;
                                        }
                                        if (bitmap.GetPixel(x1, y1 + 1).R == 255)
                                        {
                                            break;
                                        }
                                    }
                                    if (bitmap.GetPixel(x1 - 1, y).R == 255)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            vs[x, y] = 1;
                            if (bitmap.GetPixel(x + 1, y).R == 0)
                            {
                                for (int x1 = x + 1; x1 < bitmap.Width; x1++)
                                {
                                    for (int y1 = y; y1 > 0; y1--)
                                    {
                                        color = bitmap.GetPixel(x1, y1);
                                        if (color.R == 0 && color.G == 0 && color.B == 0)
                                        {
                                            vs[x1, y1] = 1;
                                        }
                                        if (bitmap.GetPixel(x1, y1 - 1).R == 255)
                                        {
                                            break;
                                        }
                                    }
                                    for (int y1 = y; y1 < bitmap.Height; y1++)
                                    {
                                        color = bitmap.GetPixel(x1, y1);
                                        if (color.R == 0 && color.G == 0 && color.B == 0)
                                        {
                                            vs[x1, y1] = 1;
                                        }
                                        if (bitmap.GetPixel(x1, y1 + 1).R == 255)
                                        {
                                            break;
                                        }
                                    }
                                    if (bitmap.GetPixel(x1 + 1, y).R == 255)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (bitmap.GetPixel(x - 1, y).R == 0)
                            {
                                for (int x1 = x - 1; x1 > 0; x1--)
                                {
                                    for (int y1 = y; y1 > 0; y1--)
                                    {
                                        color = bitmap.GetPixel(x1, y1);
                                        if (color.R == 0 && color.G == 0 && color.B == 0)
                                        {
                                            vs[x1, y1] = 1;
                                        }
                                        if (bitmap.GetPixel(x1, y1 - 1).R == 255)
                                        {
                                            break;
                                        }
                                    }
                                    for (int y1 = y; y1 < bitmap.Height; y1++)
                                    {
                                        color = bitmap.GetPixel(x1, y1);
                                        if (color.R == 0 && color.G == 0 && color.B == 0)
                                        {
                                            vs[x1, y1] = 1;
                                        }
                                        if (bitmap.GetPixel(x1, y1 + 1).R == 255)
                                        {
                                            break;
                                        }
                                    }
                                    if (bitmap.GetPixel(x1 - 1, y).R == 255)
                                    {
                                        break;
                                    }
                                }
                            }
                            count++;
                        }
                    }
                }
            }
            label1.Text = count.ToString();
            int x2 = 0, y2 = 0, max = 0, min = 0;
            count = 0;
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    count = 0;
                    x2 = 0;
                    y2 = 0;
                    if (vs[x, y] != 0)
                    {
                        for (int i = 0; i < bitmap.Width; i++)
                        {
                            for (int j = 0; j < bitmap.Height; j++)
                            {
                                if (vs[i, j] == 1)
                                {
                                    if (x2 == 0 && y2 == 0)
                                    {
                                        x2 = i;
                                        y2 = j;
                                        max = min = j;
                                        count++;
                                        vs[i, j] = 0;
                                    }
                                    else
                                    {
                                        if ((i == x2 + 1 || i == x2) && j <= max + 8 && j >= min - 8)
                                        {
                                            x2 = i;
                                            y2 = j;
                                            count++;
                                            vs[i, j] = 0;
                                            if (max < j)
                                            {
                                                max = j;
                                            }
                                            if (min > j)
                                            {
                                                min = j;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        label1.Text += " " + count.ToString();
                    }
                }
            }
            bitmap.Dispose();
        }
    }
}
