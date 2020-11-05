using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeEF.Logic.Implementations
{
<<<<<<< HEAD
    public class CustomersLogic : ICustomersLogic
    {
        private readonly NorthwindContext context;

        public CustomersLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Customers> GetCustomers()
=======
    public class CustomersLogic : BaseLogic, ILogic<Customers>
    {

        public List<Customers> GetAll()
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Customers.ToList();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public Customers GetCustomers(int id)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customers GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Customers GetOne(string id)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Customers.FirstOrDefault(r => r.CustomerID.Equals(id));
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void AddCustomers(Customers customers)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Customers customers)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Customers.Add(customers);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateCustomers(Customers customers)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Customers customers)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Entry(customers).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                throw;
            }
        }
=======
                throw ex;
            }
        }
        public void Delete(Customers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            try
            {
                context.Customers.Remove(this.GetOne(id));
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
    }
}
