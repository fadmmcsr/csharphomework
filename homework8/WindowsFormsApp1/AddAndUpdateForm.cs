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
    public partial class AddAndUpdateForm : Form
    {
        public bool isAdd;
        bool succeed;
        OrderService orderService;
        public AddAndUpdateForm(StartForm form)
        {
            InitializeComponent();
            if (isAdd)
                this.Text = "添加";
            else
                this.Text = "修改";
            this.orderService = form.orderService;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            succeed = false;
            while (!succeed)
            {
                if (isAdd)
                    succeed = orderService.AddOrder(txt_Name.Text, txt_Address.Text);
                else
                    succeed = orderService.UpdateOrder(txt_Name.Text, txt_Address.Text);
                if (!succeed)
                    lbl_Status.Text = "异常输入";
            }
            this.Close();            return;
        }
    }
}
