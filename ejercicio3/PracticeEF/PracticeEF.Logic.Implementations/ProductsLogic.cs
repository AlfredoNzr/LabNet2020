using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using PracticeEF.Logic.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEF.Logic.Implementations
{
    public class ProductsLogic : BaseLogic, ILogic<Products>
    {

        public List<Products> GetAll()
        {
            try
            {
                return context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Products GetOne(int id)
        {
            try
            {
                return context.Products.FirstOrDefault(r => r.ProductID.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Products products)
        {
            try
            {
                context.Products.Add(products);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Products products)
        {
            try
            {
                context.Entry(products).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Products products)
        {
            try
            {
                context.Products.Remove(products);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
