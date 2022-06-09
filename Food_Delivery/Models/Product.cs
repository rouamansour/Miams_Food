using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
