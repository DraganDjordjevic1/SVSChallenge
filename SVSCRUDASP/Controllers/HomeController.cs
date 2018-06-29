using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVSCRUDASP.Controllers
{
      public class HomeController : Controller
      {

            private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

            

            public ActionResult Index()
            {
                  try
                  {
                        logger.Trace("Main Window Opened");
                        return View();
                  }
                  catch (Exception ex)
                  {
                        logger.Error(ex);
                        throw;
                  }
                 
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