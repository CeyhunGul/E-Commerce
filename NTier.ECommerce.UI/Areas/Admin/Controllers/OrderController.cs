using NTier.ECommerce.MODEL.Entity;
using NTier.ECommerce.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace NTier.ECommerce.UI.Areas.Admin.Controllers
{
    //deneme
    public class OrderController :Controller
    {
        OrderService orderService = new OrderService();

        public ActionResult Index()
        {
            //todo: üyeler listelenecek.
            var users = orderService.GetAll().ToList();
            return View(users);
        }
        public PartialViewResult Add()
        {
            Order temp = new Order();

            return PartialView(temp);
        }

        [HttpPost]
        public ActionResult Add(Order order)
        { 
                Order temp = order;
                orderService.Add(order);
               
                
                return RedirectToAction("Index");
        }


        public PartialViewResult Detail(Guid id)
        {
          
                Order temp = orderService.GetById(id);

                return PartialView(temp);
            
               
            
        }


        public PartialViewResult Edit(Guid id)
        {
           
            
                Order temp = orderService.GetById(id);
                return PartialView(temp);
            


        }
        [HttpPost]
        public ActionResult Edit(Order order)
        {
            
            
                Order temp = orderService.GetById(order.ID);
                temp.Name = order.Name;
               
              
                return RedirectToAction("Index");
            


        }

        public ActionResult Delete(Guid id)
        {
            
            
                Order temp = orderService.GetById(id);
                orderService.Remove(temp);
                
                return RedirectToAction("Index");
            
        }
    }
}