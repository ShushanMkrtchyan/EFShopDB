using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   namespace EFShop
{
    public class Shop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection <Product> Products { get; set;}
        
    }
}
