using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class ProductInfo : Form
    {
        private Product _newProduct;
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string price = tbPrice.Text; //


            //int iPrice;
            //try
            //{
            //    string price = tbPrice.Text;
            //    iPrice = Int32.Parse(price);
            //}
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("โปรดใส่ข้อมูลให้ครบ");
            //    return;
            //}

            _newProduct = new Product(name, price); //iPrice

            this.DialogResult = DialogResult.OK;
        }

        public Product getProduct() { return _newProduct; }
    }
}
