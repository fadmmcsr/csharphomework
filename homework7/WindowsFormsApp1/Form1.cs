using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(nText.Text);
                
                leng = Convert.ToInt32(lengText.Text);
                per1 = Convert.ToDouble(per1Text.Text);
                per2 = Convert.ToDouble(per2Text.Text);
                th1 = Convert.ToDouble(th1Text.Text) * Math.PI / 180;
                th2 = Convert.ToDouble(th2Text.Text) * Math.PI / 180;
            }
            catch(Exception)
            {
                statusLabel.Text = "输入有误\n请检查";
                return;
            }
            color = colorComboBox.Text;
            if (n <= 1 || n >= 20)
            {
                statusLabel.Text = "递归深度建议\n在1-20之间";
                return;
            }
            if (color == "")
            {
                statusLabel.Text = "未选择颜色";
                return;
            }
            graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor);
            DrawCayleyTree(n, this.Width / 2, 310, leng, -Math.PI / 2);
            
            statusLabel.Text = "完成";
        }
        private Graphics graphics;
        int n;
        double leng;
        double th1;
        double th2;
        double per1;
        double per2;
        string color;
        void DrawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            DrawLine(x0, y0, x1, y1);
            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void DrawLine(double x0,double y0,double x1,double y1)
        {
            switch(color)
            {
                case "Blue":
                    graphics.DrawLine(Pens.Blue, (float)x0, (float)y0, (float)x1, (float)y1);
                    break;
                case "Black":
                    graphics.DrawLine(Pens.Black, (float)x0, (float)y0, (float)x1, (float)y1);
                    break;
                case "Red":
                    graphics.DrawLine(Pens.Red, (float)x0, (float)y0, (float)x1, (float)y1);
                    break;
                case "Yellow":
                    graphics.DrawLine(Pens.Yellow, (float)x0, (float)y0, (float)x1, (float)y1);
                    break;
                case "Green":
                    graphics.DrawLine(Pens.Green, (float)x0, (float)y0, (float)x1, (float)y1);
                    break; 
            }
        }
    }
}
