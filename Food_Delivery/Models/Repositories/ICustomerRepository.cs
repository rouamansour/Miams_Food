using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Models.Repositories
{
    interface ICustomerRepository
    {
        IList<Customer> GetAllCustomers();

    }
}
