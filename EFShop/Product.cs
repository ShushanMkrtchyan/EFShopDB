using System.ComponentModel.DataAnnotations.Schema;

namespace EFShop
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public int? Price { get; set; }

        [ForeignKey("Shop")]
        public int ShopId { get; set; }

        public Shop Shop { get; set; }
    }
}