using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsValidation.Models;
using ProductsValidation.Services;
using ProductsValidation.CustomValidation;

namespace ProductsValidation.Controllers
{
    
    public class ProductsController : Controller
    {
        private List<Product> myProducts;

        public ProductsController(Data data)
        {
            myProducts = data.Products;
        }
        
        public IActionResult Index(int filterId, string filtername)
        {
            return View(myProducts);
        }

        public IActionResult Details(int id)
        {
            Product prod = myProducts.Find(prod => prod.Id == id);
            if (prod != null)
            {
                return View("View", prod);
            }

            return View("NotExists");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product prod = myProducts.Find(prod => prod.Id == id);
            if (prod != null)
            {
                return View(prod);
            }

            return View("NotExists");
        }
        [HttpPost]
        public IActionResult Edit(Product product) //yura ts 1
        {
            if (ModelState.IsValid)
            {
                myProducts[myProducts.FindIndex(prod => prod.Id == product.Id)] = product;
                return View("View", product);
            }
            return View(product);
        }


        [HttpPost]
        public IActionResult Create(Product product) //ts 1
        {
            if (ModelState.IsValid)                 //start vald
            {
                myProducts.Add(product);
                return View("View", product);
            }

            return View(product);
        }

        public IActionResult Create()
        {
            return View(new Product(){Id = myProducts.Last().Id + 1});
        }

        public IActionResult Delete(int id)
        {
            myProducts.Remove( myProducts.Find(product => product.Id == id));
            return View("Index", myProducts);
        }

        [HttpGet] // ts 4 yura
        public IActionResult BulkEdit(Product.Category category)
        {
            var filtered = myProducts.Where(p => p.Type == category).ToList(); 

            var viewModel = new BulkEditViewModel 
            {
                Category = category,
                Products = filtered
            };

            return View(viewModel); 
        } 

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
