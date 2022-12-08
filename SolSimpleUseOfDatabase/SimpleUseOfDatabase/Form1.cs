using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUseOfDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            addProduct.ShowDialog();
        }
        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

        }



    }
}
