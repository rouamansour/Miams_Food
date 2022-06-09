using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
