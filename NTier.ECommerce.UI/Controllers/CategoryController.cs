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
    public class CategoryController : Controller
    {
        CategoryService cs;
        public CategoryController()
        {
            cs = new CategoryService();
        }

        public ActionResult Index()
        {
           
            return View(cs.GetActive());
        }

        public ActionResult Remove(Guid id)
        {
            cs.Remove(id);
            return RedirectToAction("Index");
        }
    }
}