using PracticeEF.Logic.Implementations;
using PracticeEF.ResourceAccess.ViewModels;
using PracticeEF.CrossCutting.Utils.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PracticeEF.ResourceAccess.Entities;
using Newtonsoft.Json;

namespace PracticaEF.Interfaces.WebAPI.Controllers
{
    public class CategoriesController : ApiController
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();

        [HttpGet]
        // GET api/values
        public IEnumerable<string> Get()
        {
            List<Categories> categories = categoriesLogic.GetAll();
            List<CategoriesView> categoriesViews = (from cat in categories
                                                    select new CategoriesView()
                                                    {
                                                        CategoryID = cat.CategoryID,
                                                        CategoryName = cat.CategoryName,
                                                        Description = cat.Description,
                                                        Picture = cat.Picture
                                                    }).ToList();
            
            return (new string[] { JsonConvert.SerializeObject(categoriesViews) });
        }

        [HttpGet]
        // GET api/values/5
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(categoriesLogic.GetOne(id).ToViewModel());
        }

        [HttpPost]
        // POST api/values
        public string Post([FromBody] CategoriesView categoriesView)
        {
            categoriesLogic.Insert(categoriesView.ToEntity());
            return "Category Created Successfully";
        }

        [HttpPut]
        // PUT api/values/5
        public string Put([FromBody] CategoriesView categoriesView)
        {
            categoriesLogic.Modify(categoriesView.ToEntity());
            return "Category Modified Successfully";
        }

        [HttpDelete]
        // DELETE api/values/5
        public string Delete(int id)
        {
            categoriesLogic.Delete(id);
            return "Category Removed Successfully";
        }
    }
}