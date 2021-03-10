using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace LoggingAspCoreHandOn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var log = LogManager.GetLogger("mylog");
            log.Info("First log");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}