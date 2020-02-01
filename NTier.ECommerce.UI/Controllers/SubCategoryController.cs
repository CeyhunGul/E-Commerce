using NTier.ECommerce.MODEL.Context;
using NTier.ECommerce.MODEL.Entity;
using NTier.ECommerce.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTier.ECommerce.UI.Controllers
{
    public class SubCategoryController : Controller
    {
        SubCategoryService subCategoryService;
        CategoryService categoryService;
        public SubCategoryController()
        {
            categoryService = new CategoryService();
            subCategoryService = new SubCategoryService();
        }
        // GET: SubCategory
        public PartialViewResult Index()
        {
            using (ProjectContext db = new ProjectContext())
            {
                var result = db.SubCategories.ToList();

                return PartialView(result);
            }
               
        }
        //todo:Dropdownlist e Categoryler Listelenecek ve ordan seçilen değerin post metoduna geri gelmesi gerekli.
        public PartialViewResult Add()
        {
            ViewBag.Categories = categoryService.GetAll();

            return PartialView();
        }
        [HttpPost]
        public void Add(SubCategory subCategory)
        {
            
            subCategoryService.Add(subCategory);
            //return RedirectToAction("Index");
        }
        //todo:Edit, Details ve Remove da eklenecek

        


    }
}