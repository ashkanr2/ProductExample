using Microsoft.AspNetCore.Mvc;
using ProductExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductExample.Controllers
{

    public class ProductController : Controller
    {
        private List<Product> products = new List<Product>
        {
        new Product { Id = 1, Name = "محصول 1", Price = 10.99m },
        new Product { Id = 2, Name = "محصول 2", Price = 20.50m },
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            //_productservice.add();
            products.Add(product);
            return RedirectToAction("Index");
            //return RedirectToAction("Edit", "Product",1);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);
            //if (product == null)
            //{

            //}
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {

            Product existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }

            return RedirectToAction("Index");
        }



    }
}
