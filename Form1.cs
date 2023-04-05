using System.Numerics;

namespace MyApp
{
    public partial class Form1 : Form
    {
        List<Product> listProduct = new List<Product>();
        private Stream productFilePath;


        public string Name { get; set; }
        public string Price { get; set; } //


        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            LoadData();
        }

        private void LoadData()
        {
            string path = "ap.txt";
            if (File.Exists(path))
            {
                List<Product> products = new List<Product>();
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string name = parts[0];
                        string price = parts[1]; //int.Parse(parts[1]);

                        Product product = new Product(name, price);
                        products.Add(product);
                    }
                }
                dataGridView1.DataSource = products;
            }

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string price = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


                Name = name;
                Price = price;


                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductInfo form1 = new ProductInfo();
            form1.ShowDialog();

            if (form1.DialogResult == DialogResult.OK)
            {
                Product newProduct = form1.getProduct();

                this.listProduct.Add(newProduct);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listProduct;
                form1.Close();
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt";
            saveFileDialog.Title = "Save Data";
            saveFileDialog.FileName = "AllProduct.txt";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {

                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Product item in listProduct)
                    {
                        writer.WriteLine(String.Format("{0},{1}",
                            item.Name,
                            item.Price));
                    }
                }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TEXT|*.txt"; ;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                List<Product> products = new List<Product>();
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        string price = fields[1]; //int.Parse(fields[1]);

                        Product product = new Product(name, price);
                        products.Add(product);
                        line = reader.ReadLine();
                    }
                    this.dataGridView1.DataSource = products;

                }
            }
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListofProduct listofproduct = new ListofProduct();
            listofproduct.ShowDialog();
            listofproduct = null;
            this.Show();
        }

        private void SaveData()
        {
            string path = "ap.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string name = row.Cells[0].Value.ToString();
                        string price = row.Cells[1].Value.ToString(); //int.Parse(row.Cells[1].Value.ToString());

                        string line = string.Format("{0},{1}", name, price);
                        writer.WriteLine(line);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string SearchResult { get; set; }
    }
}