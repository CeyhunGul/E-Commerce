using NTier.ECommerce.COMMON;
using NTier.ECommerce.MODEL.Context;
using NTier.ECommerce.MODEL.Entity;
using NTier.ECommerce.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTier.ECommerce.UI.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();
        SubCategoryService subCategoryService = new SubCategoryService();

        public ActionResult Index()
        {
            //todo: üyeler listelenecek.
            var users = productService.GetAll().ToList();
            
            return View(users);
        }
        public ActionResult Add()
        {
            TempData["SubCategories"] = subCategoryService.GetActive();

            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product, HttpPostedFileBase ImagePath)
        {
            if (ModelState.IsValid)
            {

                product.ImagePath = ImageUploader.UploadImage("~/Content/images", ImagePath);
                if (product.ImagePath == "0")
                {
                    ViewBag.Error = "Dosya Boş";
                }else if(product.ImagePath == "1")
                {
                    ViewBag.Error = "Zaten bu isimde dosya bulunmaktadır";
                }
                else if (product.ImagePath == "2")
                {
                    ViewBag.Error = "Dosya uzantısı belirtilenlere uymuyor";
                }
                else
                {
                    ViewBag.Produts = productService.GetAll();
                    productService.Add(product);
                    return RedirectToAction("Index");
                }


                    
            }

            return View();
        }


        public PartialViewResult Detail(Guid id)
        {

           Product temp = productService.GetById(id);

            return PartialView(temp);



        }


        public ActionResult Update(Guid id)
        {
            Product pr = productService.GetById(id);

            return View(pr);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            Product pr = productService.GetById(product.ID);
            pr.ID = product.ID;
            pr.Name = product.Name;
            pr.Price = product.Price;
            pr.UnitsInStock = product.UnitsInStock;
            productService.Update(pr);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {


            Product temp = productService.GetById(id);
            productService.Remove(temp);

            return RedirectToAction("Index");

        }
    }
}