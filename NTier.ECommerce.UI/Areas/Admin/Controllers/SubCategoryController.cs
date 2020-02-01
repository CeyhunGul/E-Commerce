using NTier.ECommerce.MODEL.Entity;
using NTier.ECommerce.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTier.ECommerce.UI.Areas.Admin.Controllers
{
    public class SubCategoryController : Controller
    {
        SubCategoryService SubCategoryService = new SubCategoryService();
        CategoryService cs = new CategoryService();
        // GET: Admin/AppUser
        public ActionResult List()
        {

            ViewBag.Categories = cs.GetActive();
            return View(SubCategoryService.GetActive());
        }
    
        public ActionResult Add()
        {
            

            return View(cs.GetActive());
        }

        [HttpPost]
        public ActionResult Add(SubCategory subCategory)
        {
            subCategory.ID = Guid.NewGuid();
            SubCategoryService.Add(subCategory);
            return RedirectToAction("List");
        }


        public PartialViewResult Detail(Guid id)
        {

            SubCategory temp = SubCategoryService.GetById(id);

            return PartialView(temp);



        }


        public ActionResult Edit(Guid id)
        {

            SubCategory temp = SubCategoryService.GetById(id);
            TempData["cs"] = cs.GetActive();
            return View(temp);
           


        }
        [HttpPost]
        public ActionResult Edit(SubCategory subCategory)
        {


            SubCategoryService.Update(subCategory);
            return RedirectToAction("List");



        }

        public ActionResult Delete(Guid id)
        {


            SubCategory temp = SubCategoryService.GetById(id);
            SubCategoryService.Remove(temp);

            return RedirectToAction("List");

        }
    }
}