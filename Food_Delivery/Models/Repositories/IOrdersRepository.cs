using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Models.Repositories
{
    interface IOrdersRepository
    {
        IList<Order> GetAllOrders();
        void AddOrder(Order order);
        void EditOrder(Order order);
        void DeleteOrder(Order order);
    }
}
