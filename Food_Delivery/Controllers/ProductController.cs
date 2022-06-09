using Food_Delivery.Models;
using Food_Delivery.Models.Repositories;
using Food_Delivery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductsRepository _productRepository;

        public ProductController(ILogger<ProductController> logger, IProductsRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository; //injection des dependences 
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAllPrd();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productRepository.AddPrd(product);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            //var product = _productRepository.GetProduct(id);
            //return View(product);
            return View(_productRepository.GetByIdPrd(id));
        }


        public ActionResult Delete(int id)
        {
            return View(_productRepository.GetByIdPrd(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Product product)
        {
            try
            {
                _productRepository.DeletePrd(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            ViewBag.ProductID = new SelectList(_productRepository.GetAllPrd(), "id", "name");
            return View(_productRepository.GetByIdPrd(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            try
            {
                ViewBag.id = new SelectList(_productRepository.GetAllPrd(), "id", "name", product.Id);
                _productRepository.EditPrd(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
