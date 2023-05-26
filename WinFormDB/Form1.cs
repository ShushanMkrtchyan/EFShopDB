using EFShop;
using System.Reflection.PortableExecutable;

namespace WinFormDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_Products.Items.Clear();
            using(DataContext db = new DataContext())
            {
                var products = db.Products.ToList();
                listBox_Products.DataSource = products;
                listBox_Products.DisplayMember = "Name";
                listBox_Products.ValueMember = "ID";
                

            }
        }

        private void button1_Click(object sender, EventArgs e) // Add
        {
            AddProductForm form = new AddProductForm();
            form.Show();
        }

        private void listBox_Products_SelectedIndexChanged(object sender, EventArgs e) //update
        {
            ProductEdit edit = new ProductEdit((Product)listBox_Products.SelectedValue);
            edit.Show();
            
        }

    }
}