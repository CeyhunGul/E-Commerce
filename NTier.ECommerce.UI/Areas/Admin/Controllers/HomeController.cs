using NTier.ECommerce.MODEL.Context;
using NTier.ECommerce.MODEL.Entity;
using NTier.ECommerce.SERVICE.Option;
using NTier.ECommerce.UI.Filters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTier.ECommerce.UI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home

        //[AuthenticationFilter]
        //[Authorize]
        public ActionResult Index()
        {
            AppUserService appUserService = new AppUserService();
            var appUSer = appUserService.GetAll();
            var countUsers = appUSer.Count();
            Session["countUsers"] = countUsers.ToString();//kullanıcı sayısı


            ProductService productService = new ProductService();
            var product = productService.GetAll();
            var countProduct = product.Count();
            Session["countProduct"] = countProduct;// urun sayısı

            var sonKullanici = appUserService.GetAll().OrderByDescending(x => x.CreatedDate).Take(3);
            TempData["sonKullanıcı"] = sonKullanici;

            var sonUrun = productService.GetAll().OrderByDescending(x => x.CreatedDate).Take(3);
            TempData["sonUrun"] = sonUrun;

            //toplam geliri hesaplamam için order detail da quantity, price, discount propertyleri olmalı

            OrderDetailService orderDetailService = new OrderDetailService();
            var totalPrice = orderDetailService.GetAll().Sum(x => x.Quantity * x.Price * 1 - (x.Discount));
                Session["totalPrice"] = totalPrice;

            //SqlCommand cmd = new SqlCommand("SELECT SUM((UnitPrice*Quantity)-(UnitPrice*Quantity*Discount))FROM OrderDetails");
            var orderDetail = orderDetailService.GetAll();
            var countOrderDetail = orderDetail.Count();
            Session["countOrder"] = countOrderDetail;
            return View();
        }
        public ActionResult AddProduct()
        {
            return View();
        }
        
        
    }
}