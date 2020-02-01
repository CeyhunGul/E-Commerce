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
    public class AppUserController : Controller
    {
        AppUserService appUserService = new AppUserService();
        // GET: Admin/AppUser
        public ActionResult AppUserList()
        {
            var AppUser = appUserService.GetAll();
            return View(AppUser);
        }
        OrderService orderService = new OrderService();

        //Admin Profile 
        //todo:Admin Profile butonuna bağlanacak.
        public ActionResult AdminProfile(Guid id)
        {
            var admin = appUserService.GetById(id);
            return View(admin);
        }



        public ActionResult Index()
        {
            //todo: üyeler listelenecek.
            var users = orderService.GetAll().ToList();
            return View(users);
        }
        public PartialViewResult Add()
        {
            AppUser temp = new AppUser();

            return PartialView(temp);
        }

        [HttpPost]
        public ActionResult Add(AppUser appUser)
        {

            appUserService.Add(appUser);
            return RedirectToAction("Index");
        }


        public PartialViewResult Detail(Guid id)
        {

            AppUser temp = appUserService.GetById(id);

            return PartialView(temp);



        }


        public PartialViewResult Edit(Guid id)
        {


            AppUser temp = appUserService.GetById(id);
            return PartialView(temp);



        }
        [HttpPost]
        public ActionResult Edit(AppUser appUser)
        {


            AppUser temp = appUserService.GetById(appUser.ID);
            temp.Name = appUser.Name;


            return RedirectToAction("Index");



        }

        public ActionResult Delete(Guid id)
        {


            AppUser temp = appUserService.GetById(id);
            appUserService.Remove(temp);

            return RedirectToAction("Index");

        }
    }
}