using PracticeEF.CrossCutting.Utils.Mappers;
using PracticeEF.Logic.Implementations;
using PracticeEF.ResourceAccess.Entities;
using PracticeEF.ResourceAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PracticeEF.Interfaces.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();

        // GET: Categories
        public ActionResult Index()
        {
            List<CategoriesView> categoriesView = CreateListCategoriesView();

            return View(categoriesView);
        }


        public ActionResult Delete(int id)
        {
            try
            {
                categoriesLogic.Delete(id);
                ViewBag.MsgResult = "Category Deleted Successfully";
                List<CategoriesView> categoriesView = CreateListCategoriesView();
                return View("Index", categoriesView);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult InsertUpdate(int? id)
        {
            if (!id.HasValue)
            {
                return View();
            }
            else {
                Categories categories = categoriesLogic.GetOne(Convert.ToInt32(id));

                return View(categories.ToViewModel());
            }

        }
       
        public ActionResult ModifyAction(CategoriesView categoryView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this.categoriesLogic.Modify(categoryView.ToEntity());
                    return Json(new
                    {
                        success = true,
                        title = "Modified",
                        message = "Category Modified Successfully"
                    },
                        JsonRequestBehavior.AllowGet);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                string error = ModelState.Values.SelectMany(v => v.Errors).ToList().First().ErrorMessage;
                return Json(new
                {
                    success = false,
                    title = "Not Modified",
                    message = error
                }, JsonRequestBehavior.AllowGet);
            }
                
        }


        public ActionResult InsertAction(CategoriesView categoryView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this.categoriesLogic.Insert(categoryView.ToEntity());
                    return Json(new
                    {
                        success = true,
                        title = "Created",
                        message = "Category Created Successfully"
                    },
                        JsonRequestBehavior.AllowGet);
                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                string error = ModelState.Values.SelectMany(v => v.Errors).ToList().First().ErrorMessage;
                return Json(new
                {
                    success = false,
                    title = "Not Created",
                    message = error
                }, JsonRequestBehavior.AllowGet);
            }
            
            
        }

        private List<CategoriesView> CreateListCategoriesView()
        {
            List<Categories> categories = categoriesLogic.GetAll();

            List<CategoriesView> categoriesView = (from category in categories
                                                   select new CategoriesView()
                                                   {
                                                       CategoryID = category.CategoryID,
                                                       CategoryName = category.CategoryName,
                                                       Description = category.Description,
                                                       Picture = category.Picture
                                                   }
                                                   ).ToList();
            return categoriesView;
        }

    }
}