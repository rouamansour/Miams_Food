using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Models
{
    public class CommandLine
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int QuantityOrdered { get; set; }
        public int TotalCommand { get; set; }

    }
}
