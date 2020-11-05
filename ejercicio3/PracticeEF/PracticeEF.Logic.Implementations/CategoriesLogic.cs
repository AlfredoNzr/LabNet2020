using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using PracticeEF.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;


namespace PracticeEF.Logic.Implementations
{
    public class CategoriesLogic : ICategoriesLogic
    {
        private readonly NorthwindContext context;

        public CategoriesLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Categories> GetCategories()
        {
            try
            {
                return context.Categories.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Categories GetCategories(int id)
        {
            try
            {
                return (from c in context.Categories
                          where c.CategoryID == id
                          select c).SingleOrDefault();
                 //probando distintas formas          
                //return context.Categories.FirstOrDefault(r => r.CategoryID.Equals(id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void AddCategories(Categories categories)
        {
            try
            {
                context.Categories.Add(categories);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public void UpdateCategories(Categories pCategories)
        {
            //Categories categories = context.Categories.First(r => r.CategoryID.Equals(pCategories.CategoryID));
            //categories.CategoryID = pCategories.CategoryID;
            //.....
            //..... MAS DENSO
            try
            {
                context.Entry(pCategories).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void DeleteCategories(Categories categories)
        {
            try
            {
                context.Categories.Remove(categories);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
