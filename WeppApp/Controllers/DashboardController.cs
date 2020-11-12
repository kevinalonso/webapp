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
        private DashboardViewModel _dashboardViewModel = new DashboardViewModel();

        public ActionResult Dashboard(string choiceData)
        {
           

            if (choiceData == "tva")
            {
                VatDAL vatDAL = new VatDAL();
                _dashboardViewModel.DisplayVATs = vatDAL.GetVATs();
                HidenOrDisplay(choiceData, _dashboardViewModel);
            }
            else if (choiceData == "account")
            {
                AccountDAL accountDAL = new AccountDAL();
                _dashboardViewModel.DisplayAccounts = accountDAL.GetAccounts();
                HidenOrDisplay(choiceData, _dashboardViewModel);
            }
            else if (choiceData == "category")
            {
                CategoryDAL categoryDAL = new CategoryDAL();
                _dashboardViewModel.DisplayCategories = categoryDAL.GetCategorys();
                HidenOrDisplay(choiceData, _dashboardViewModel);
            }
            else if(choiceData == "classified")
            {
                ClassifiedDAL classifiedDAL = new ClassifiedDAL();
                _dashboardViewModel.DisplayClassifieds = classifiedDAL.GetClassifieds();
                HidenOrDisplay(choiceData, _dashboardViewModel);
            }

            return View(_dashboardViewModel);
        }

        [HttpPost]
        public ActionResult Authentication()
        {
            return View("~/Views/Dashboard/Dashboard.cshtml", _dashboardViewModel);
        }

        public ActionResult ListVat()
        {
            return RedirectToAction("Dashboard", new { choiceData ="tva" });
        }

        public ActionResult AccountList()
        {
            return RedirectToAction("Dashboard", new { choiceData = "account" });
        }

        public ActionResult CategoryList()
        {
            return RedirectToAction("Dashboard", new { choiceData = "category" });
        }

        public ActionResult ClassifiedList()
        {
            return RedirectToAction("Dashboard", new { choiceData = "classified" });
        }

        private void HidenOrDisplay(string value, DashboardViewModel _dashboardViewModel)
        {
            switch (value)
            {
                case "tva":
                    _dashboardViewModel.IsClickedVAT = true;
                    _dashboardViewModel.IsClickedAccount = false;
                    _dashboardViewModel.IsClickedCategory = false;
                    _dashboardViewModel.IsClickedClassiefed = false;
                    break;
                case "account":
                    _dashboardViewModel.IsClickedVAT = false;
                    _dashboardViewModel.IsClickedAccount = true;
                    _dashboardViewModel.IsClickedCategory = false;
                    _dashboardViewModel.IsClickedClassiefed = false;
                    break;
                case "category":
                    _dashboardViewModel.IsClickedVAT = false;
                    _dashboardViewModel.IsClickedAccount = false;
                    _dashboardViewModel.IsClickedCategory = true;
                    _dashboardViewModel.IsClickedClassiefed = false;
                    break;
                case "classified":
                    _dashboardViewModel.IsClickedVAT = false;
                    _dashboardViewModel.IsClickedAccount = false;
                    _dashboardViewModel.IsClickedCategory = false;
                    _dashboardViewModel.IsClickedClassiefed = true;
                    break;
                default:
                    _dashboardViewModel.IsClickedVAT = false;
                    _dashboardViewModel.IsClickedAccount = false;
                    _dashboardViewModel.IsClickedCategory = false;
                    _dashboardViewModel.IsClickedClassiefed = false;
                    break;
            }
        }
    }
}