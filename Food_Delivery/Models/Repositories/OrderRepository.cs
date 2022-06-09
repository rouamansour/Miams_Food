using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Models.Repositories
{
    public class OrderRepository: IOrdersRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }
        public IList<Order> GetAllOrders()
        {
            return _context.Orders.OrderBy(order => order.Name).ToList();
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void EditOrder(Order order)
        {
            Order orderExcisting = _context.Orders.Find(order.Id);
            if (orderExcisting != null)
            {
                orderExcisting.Name = order.Name;
                orderExcisting.Date = order.Date;
                _context.SaveChanges();
            }
        }

        public void DeleteOrder(Order ord)
        {
            Order ord1 = _context.Orders.Find(ord.Id);
            if (ord1 != null)
            {
                _context.Orders.Remove(ord1);
                _context.SaveChanges();
            }
        }
    }

}
