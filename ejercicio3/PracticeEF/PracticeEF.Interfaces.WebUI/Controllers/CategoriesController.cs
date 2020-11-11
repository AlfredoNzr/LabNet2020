using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeEF.ResourceAccess.Entities;
using PracticeEF.Logic.Implementations;
using System.Web.UI.WebControls;

namespace PracticeEF.Interfaces.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();

        // GET: Categories
        public ActionResult Index()
        {
            return View(this.categoriesLogic.GetAll());
        }

        public ActionResult Delete(int id)
        {
            categoriesLogic.Delete(id);

            return RedirectToAction("Index", this.categoriesLogic.GetAll());
        }
       
        public ActionResult ModifyAction(Categories category)
        {
            this.categoriesLogic.Modify(category);
            return RedirectToAction("Index", this.categoriesLogic.GetAll());
        }

        public ActionResult InsertUpdate(int? id)
        {
            if (!id.HasValue)
            {
                return View();
            }
            else {
                return View(categoriesLogic.GetOne(Convert.ToInt32(id)));
            }

        }

        public ActionResult InsertAction(Categories category)
        {
            this.categoriesLogic.Insert(category);
            return RedirectToAction("Index", this.categoriesLogic.GetAll());
        }
    }
}