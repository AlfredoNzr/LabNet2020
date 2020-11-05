using PracticeEF.Logic.Implementations;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeEF.Interfaces.WebUI.Controllers
{
    public class CustomersController : Controller
    {
        CustomersLogic customersLogic = new CustomersLogic();

        // GET: Categories
        public ActionResult Index()
        {
            return View(this.customersLogic.GetAll());
        }

        public ActionResult Delete(string id)
        {
            customersLogic.Delete(id);

            return RedirectToAction("Index", this.customersLogic.GetAll());
        }

        public ActionResult Modify(string id)
        {
            return View(customersLogic.GetOne(id));
        }

        public ActionResult ModifyAction(Customers customer)
        {
            this.customersLogic.Modify(customer);
            return RedirectToAction("Index", this.customersLogic.GetAll());
        }

        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult InsertAction(Customers customer)
        {
            this.customersLogic.Insert(customer);
            return RedirectToAction("Index", this.customersLogic.GetAll());
        }
    }
}