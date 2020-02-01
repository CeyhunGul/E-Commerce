using NTier.ECommerce.MODEL.Entity;
using NTier.ECommerce.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace NTier.ECommerce.UI.Areas.Admin.Controllers
{
    public class OrderDetailController : Controller
    {
        OrderDetailService OrderDetailService = new OrderDetailService();
        // GET: Admin/AppUser
       
        

        public ActionResult Index()
        {
            //todo: üyeler listelenecek.
            var users = OrderDetailService.GetAll().ToList();
            return View(users);
        }
        public PartialViewResult Add()
        {
            OrderDetail temp = new OrderDetail();

            return PartialView(temp);
        }

        [HttpPost]
        public ActionResult Add(OrderDetail  orderDetail)
        {

            OrderDetailService.Add(orderDetail);
            return RedirectToAction("Index");
        }


        public PartialViewResult Detail(Guid id)
        {

            OrderDetail temp = OrderDetailService.GetById(id);

            return PartialView(temp);



        }


        public PartialViewResult Edit(Guid id)
        {


            OrderDetail temp = OrderDetailService.GetById(id);
            return PartialView(temp);



        }
        [HttpPost]
        public ActionResult Edit(OrderDetail orderDetail)
        {


            OrderDetail temp = OrderDetailService.GetById(orderDetail.ID);
            temp.Name = orderDetail.Name;


            return RedirectToAction("Index");



        }

        public ActionResult Delete(Guid id)
        {


            OrderDetail temp = OrderDetailService.GetById(id);
            OrderDetailService.Remove(temp);

            return RedirectToAction("Index");

        }
    }
}