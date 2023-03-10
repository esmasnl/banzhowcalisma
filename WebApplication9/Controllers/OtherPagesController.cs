using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class OtherPagesController : Controller
    {
        // GET: OtherPages
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sidebar()
        {
            return View();
        }
        public ActionResult Faq()
        {
            return View();
        }
        public ActionResult o404()
        {
            return View();
        }
    }
}