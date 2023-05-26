using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFShop;

namespace WinFormDB
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            using(DataContext db = new DataContext())
            {
                var shopnames = db.Shops.ToList();
                comboBox1.DataSource = shopnames;
                comboBox1.ValueMember= "ID";
                comboBox1.DisplayMember= "Name";    
            }
        }

        private void button4_Click(object sender, EventArgs e) //Save 
        {
            Product product = new Product();

            product.Name = textBox1.Text;

            if (Int32.TryParse(textBox2.Text, out int price))
            {
                product.Price = price;
            }
            product.ShopId = (int)comboBox1.SelectedValue;

            using(DataContext db = new DataContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
