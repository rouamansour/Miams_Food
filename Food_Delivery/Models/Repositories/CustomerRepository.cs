using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food_Delivery.Models;
using Microsoft.EntityFrameworkCore;

namespace Food_Delivery.Models.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;

        public CustomerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IList<Customer> GetAllCustomers()
        {
            return context.Customers.OrderBy(c => c.Name).ToList();
        }

    }
}
