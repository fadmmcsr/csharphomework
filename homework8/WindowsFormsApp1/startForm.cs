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
    public partial class StartForm : Form
    {
        public OrderService orderService;
        public StartForm()
        {
            InitializeComponent();
            cmb_Method.SelectedIndex = 0;
            orderService = new OrderService();
            orderBindingSource.ResetBindings(false);
            orderBindingSource.DataSource = orderService;
            orderItemBindingSource.DataSource = orderBindingSource.Current;
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            AddAndUpdateForm form = new AddAndUpdateForm(this);
            form.isAdd = true;
            form.ShowDialog();
        }

        private void btn_UpdateOrder_Click(object sender, EventArgs e)
        {
            AddAndUpdateForm form = new AddAndUpdateForm(this);
            form.isAdd = false;
            form.ShowDialog();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            int method = cmb_Method.SelectedIndex;
            string query = txt_QueryAndRemove.Text;
            orderService.Query(query, method);
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "xml文件|*.xml";
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            if (fileName.Length == 0)
                return;
            orderService.Import(openFileDialog.FileName);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "xml文件|*.xml";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            if (fileName.Length == 0)
                return;
            orderService.Export(saveFileDialog.FileName);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int method = cmb_Method.SelectedIndex;
            string remove = txt_QueryAndRemove.Text;
            orderService.Query(remove, method);
        }
    }
}
