using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeppApp.DAL;
using WeppApp.Models;
using WeppApp.ViewModels;

namespace WeppApp.Controllers
{
    public class DashboardController : Controller
    {
       
        public ActionResult Dashboard(string choiceData)
        {
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

            if (choiceData == "tva")
            {
                VatDAL vatDAL = new VatDAL();
                dashboardViewModel.DisplayVATs = vatDAL.GetVATs();
            }

            return View(dashboardViewModel);
        }

        [HttpPost]
        public ActionResult Authentication()
        {
            return View("~/Views/Dashboard/Dashboard.cshtml");
        }

        public ActionResult ListVat()
        {
            return RedirectToAction("Dashboard", new { choiceData ="tva" });
        }
    }
}