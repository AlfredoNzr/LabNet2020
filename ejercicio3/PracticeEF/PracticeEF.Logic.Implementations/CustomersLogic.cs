using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeEF.Logic.Implementations
{
    public class CustomersLogic : BaseLogic, ILogic<Customers>
    {

        public List<Customers> GetAll()
        {
            try
            {
                return context.Customers.ToList();
            }
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
        {
            try
            {
                return context.Customers.FirstOrDefault(r => r.CustomerID.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Customers customers)
        {
            try
            {
                context.Customers.Add(customers);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Customers customers)
        {
            try
            {
                context.Entry(customers).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
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
        
    }
}
