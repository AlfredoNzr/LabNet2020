using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using PracticeEF.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;


namespace PracticeEF.Logic.Implementations
{
    public class CategoriesLogic : BaseLogic, ILogic<Categories>
    {

        public List<Categories> GetAll()
        {
            try
            {
                return context.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Categories GetOne(int id)
        {
            try
            {
                return (from c in context.Categories
                          where c.CategoryID == id
                          select c).FirstOrDefault();
                 //probando distintas formas          
                //return context.Categories.FirstOrDefault(r => r.CategoryID.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Categories categories)
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
        
        public void Modify(Categories pCategories)
        {
            try
            {
                context.Entry(pCategories).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Categories categories)
        {
            try
            {
                context.Categories.Remove(categories);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                context.Categories.Remove(this.GetOne(id));
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
