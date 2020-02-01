using NTier.ECommerce.MODEL.Entity;
using NTier.ECommerce.SERVICE.Option;
using NTier.ECommerce.UI.Models.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTier.ECommerce.UI.Controllers
{
    public class HomeController : Controller
    {
        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();
        public ActionResult Index()
        {  
            var products = productService.GetAll();
            return View(products);
        }
        public PartialViewResult PartialCategoryListOfSide()
        {
            var categories= categoryService.GetAll();
            return PartialView(categories);
        }


        //Completed
        public ActionResult About()
        {
            return View();
        }
        //Completed
        public ActionResult Contact()
        {
            return View();
        }
    }
}