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
    public class ProductsLogic : IProductsLogic
    {
        private readonly NorthwindContext context;

        public ProductsLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Products> GetProducts()
        {
            try
            {
                return context.Products.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Products GetProduct(int id)
        {
            try
            {
                return context.Products.FirstOrDefault(r => r.ProductID.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddProducts(Products products)
        {
            try
            {
                context.Products.Add(products);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateProducts(Products products)
        {
            try
            {
                context.Entry(products).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteProducts(Products products)
        {
            try
            {
                context.Products.Remove(products);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
