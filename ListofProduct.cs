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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyApp
{
    public partial class ListofProduct : Form
    {
        public DataGridView dataGridView;

        Form1 form1 = new Form1();
        List<Product> listProduct = new List<Product>();
        List<ProductList> listproductlist = new List<ProductList>();

        public ListofProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form1 form1 = new Form1())
            {
                form1.Owner = this;
                form1.ShowDialog();


                if (!string.IsNullOrEmpty(form1.Name))
                {
                    string selectedData = form1.Name;
                    string selectedData2 = form1.Price;


                    textBox1.Text = selectedData;
                    textBox2.Text = selectedData2;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))

            {
                MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   //สำหรับเพิ่มข้อมูลไปยังdatagridviewเมื่อข้อมูลครบ
                string[] row = new string[] { textBox1.Text, textBox2.Text };
                dataGridView1.Rows.Add(row);

            }
            //ล้างtextbox

            textBox1.Clear();
            textBox2.Clear();

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(.csv)|.csv";
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCSV[0] += columnNames;
                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                var cellValue = dataGridView1.Rows[i - 1].Cells[j].Value;
                                outputCSV[i] += cellValue != null ? cellValue.ToString() + "," : ",";
                            }
                        }
                        File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        MessageBox.Show("บันทึกสำเร็จ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
