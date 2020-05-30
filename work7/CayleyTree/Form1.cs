using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*将课本中例5-31的Cayley树绘图代码进行修改。添加一组控件用以调节树的绘制参数。
 * 参数包括递归深度（n）、主干长度（leng）、
 * 右分支长度比（per1）、左分支长度比（per2）、
 * 右分支角度（th1）、左分支角度（th2）、画笔颜色（pen）。*/
namespace CayleyTree
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        int n = 10;
        int leng =100;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = Pens.Blue;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = drawPanel.CreateGraphics();
            else
            {
                graphics.Clear(Color.White);
            }
            int.TryParse(cBox_n.Text,out n);
            drawCayleyTree(n, drawPanel.Location.X + drawPanel.Width * 0.4, drawPanel.Location.Y + drawPanel.Height * 0.8, leng, -Math.PI / 2);
        }

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_lengShow.Text = trackBar1.Value.ToString();
            leng = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label_per1Show.Text = ((double)trackBar2.Value / 10).ToString();
            per1 = (double)trackBar2.Value / 10;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label_per2Show.Text = ((double)trackBar3.Value / 10).ToString();
            per2 = (double)trackBar3.Value / 10;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label_th1Show.Text = ((double)trackBar4.Value * Math.PI / 180).ToString();
            th1 = (double)trackBar4.Value * Math.PI / 180;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label_th2Show.Text = ((double)trackBar5.Value * Math.PI / 180).ToString();
            th2 = (double)trackBar5.Value * Math.PI / 180;
        }


        private void cob_Pen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = cBox_Pen.Text;
            switch (color)
            {
                case "红色":
                    pen = Pens.Red;
                    break;
                case "橙色":
                    pen = Pens.Orange;
                    break;
                case "黄色":
                    pen = Pens.Yellow;
                    break;
                case "绿色":
                    pen = Pens.Green;
                    break;
                case "青色":
                    pen = Pens.Cyan;
                    break;
                case "蓝色":
                    pen = Pens.Blue;
                    break;
                case "紫色":
                    pen = Pens.Purple;
                    break;
                case "黑色":
                    pen = Pens.Black;
                    break;
            }
        }
    }
}
