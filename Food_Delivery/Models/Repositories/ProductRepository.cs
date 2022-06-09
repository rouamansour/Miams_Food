using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Food_Delivery.Models;
using Microsoft.EntityFrameworkCore;

namespace Food_Delivery.Models.Repositories
{
    public class ProductRepository : IProductsRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public Product GetProduct(int Id)
        {
            return _context.Products.Find(Id);
        }
        public IList<Product> GetAllPrd()
        {
            return _context.Products.OrderBy(p => p.Name).ToList();
        }
        public Product GetByIdPrd(int id)
        {
            return _context.Products.Where(x => x.Id == id).Include(x => x.Orders).FirstOrDefault();
        }

        public void AddPrd(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void EditPrd(Product product)
        {
            Product productExsiting = _context.Products.Find(product.Id);
            if (productExsiting != null)
            {
                productExsiting.Name = product.Name;
                productExsiting.Price = product.Price;
                _context.SaveChanges();
            }
        }

        public void DeletePrd(Product product)
        {
            Product productExsiting = _context.Products.Find(product.Id);
            if (productExsiting != null)
            {
                _context.Products.Remove(productExsiting);
                _context.SaveChanges();
            }
        }
        public IList<Product> FindByPrdName(string name)
        {
            return _context.Products.Where(product => product.Name.Contains(name)).Include(prd => prd.Orders).ToList();
        }

    }
}
