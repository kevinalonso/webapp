using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeppApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public ActionResult Authentication()
        {
            return View();
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
    }
}