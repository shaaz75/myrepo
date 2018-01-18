using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace niksaj.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            string strName = "S";
            return View();
        }

        public ActionResult NewAction()
        {
            return View();
        }
    }
}