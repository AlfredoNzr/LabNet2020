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
<<<<<<< HEAD
    public class ProductsLogic : IProductsLogic
    {
        private readonly NorthwindContext context;

        public ProductsLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Products> GetProducts()
=======
    public class ProductsLogic : BaseLogic, ILogic<Products>
    {

        public List<Products> GetAll()
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Products.ToList();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public Products GetProduct(int id)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Products GetOne(int id)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Products.FirstOrDefault(r => r.ProductID.Equals(id));
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void AddProducts(Products products)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Products products)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Products.Add(products);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateProducts(Products products)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Products products)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Entry(products).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteProducts(Products products)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Products products)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Products.Remove(products);
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
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
            }
        }
    }
}
