using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.OrderServicce;

namespace Test.WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult OrderInfo()
        {
            OrderServiceClient client = new OrderServiceClient();
            var model = client.Find();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}