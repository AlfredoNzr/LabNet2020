using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeEF.Logic.Implementations
{
    public class CustomersLogic : ICustomersLogic
    {
        private readonly NorthwindContext context;

        public CustomersLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Customers> GetCustomers()
        {
            try
            {
                return context.Customers.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Customers GetCustomers(int id)
        {
            try
            {
                return context.Customers.FirstOrDefault(r => r.CustomerID.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddCustomers(Customers customers)
        {
            try
            {
                context.Customers.Add(customers);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateCustomers(Customers customers)
        {
            try
            {
                context.Entry(customers).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
