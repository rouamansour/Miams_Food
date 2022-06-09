using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Models.Repositories
{
    public interface IProductsRepository
    {
        Product GetProduct(int id);
        IList<Product> GetAllPrd();
        Product GetByIdPrd(int id);
        void AddPrd(Product product);
        void EditPrd(Product product);
        void DeletePrd(Product product);
        IList<Product> FindByPrdName(string name);

    }
}
