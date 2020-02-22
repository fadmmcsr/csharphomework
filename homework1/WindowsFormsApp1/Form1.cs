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
            double a, b;
            try
            {
                a = Double.Parse(num1.Text);
                b = Double.Parse(num2.Text);
            }
            catch
            {
                answer.Text = "检查数字是否正确";
                return;
            }
            switch (op.Text)
            {
                case "+":
                    answer.Text = $"{a + b}";
                    break;
                case "-":
                    answer.Text = $"{a - b}";
                    break;
                case "*":
                    answer.Text = $"{a * b}";
                    break;
                case "/":
                    if (b != 0)
                        answer.Text = $"{a / b}";
                    else
                        answer.Text = "除数不能为零";
                    break;
                default:
                    answer.Text = "请选择运算符";
                    break;
            }
        }
    }
}
