using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Main : Form
    {
        private Form1 form1;
        private ListofProduct listofproduct;
        public Main()
        {
            InitializeComponent();
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            form1 = null;
            this.Show();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListofProduct listofproduct = new ListofProduct();
            listofproduct.ShowDialog();
            listofproduct = null;
            this.Show();
        }
    }
}
