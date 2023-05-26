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
    public partial class ProductEdit : Form
    {
        private int productId;
        private Product product;
        public ProductEdit(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            using(DataContext db = new DataContext())
            {
               // var product = db.Products.FirstOrDefault(p=> p.ID == productId);
                var shopnames = db.Shops.ToList();
                comboBox1.DataSource = shopnames;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Name";
                textBox1.Text = product.Name;
                textBox2.Text= product.Price.ToString();
                comboBox1.SelectedValue=product.ShopId.ToString();
            }
        }
    }
}
