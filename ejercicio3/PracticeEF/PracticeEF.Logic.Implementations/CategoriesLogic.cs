using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using PracticeEF.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;


namespace PracticeEF.Logic.Implementations
{
<<<<<<< HEAD
    public class CategoriesLogic : ICategoriesLogic
    {
        private readonly NorthwindContext context;

        public CategoriesLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Categories> GetCategories()
=======
    public class CategoriesLogic : BaseLogic, ILogic<Categories>
    {

        public List<Categories> GetAll()
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Categories.ToList();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public Categories GetCategories(int id)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Categories GetOne(int id)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return (from c in context.Categories
                          where c.CategoryID == id
<<<<<<< HEAD
                          select c).SingleOrDefault();
=======
                          select c).FirstOrDefault();
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
                 //probando distintas formas          
                //return context.Categories.FirstOrDefault(r => r.CategoryID.Equals(id));
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                throw;
            }
        }

        public void AddCategories(Categories categories)
=======
                throw ex;
            }
        }

        public void Insert(Categories categories)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
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
        
<<<<<<< HEAD
        public void UpdateCategories(Categories pCategories)
        {
            //Categories categories = context.Categories.First(r => r.CategoryID.Equals(pCategories.CategoryID));
            //categories.CategoryID = pCategories.CategoryID;
            //.....
            //..... MAS DENSO
=======
        public void Modify(Categories pCategories)
        {
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
            try
            {
                context.Entry(pCategories).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch(Exception ex)
            {
<<<<<<< HEAD
                throw;
            }
        }

        public void DeleteCategories(Categories categories)
=======
                throw ex;
            }
        }

        public void Delete(Categories categories)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Categories.Remove(categories);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
=======
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
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
            }
        }
    }
}
