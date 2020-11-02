using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeEF.Logic.Implementations
{
    public class ShippersLogic : IShippersLogic
    {
        private readonly NorthwindContext context;

        public ShippersLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Shippers> GetShippers()
        {
            try
            {
                return context.Shippers.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Shippers GetShippers(int id)
        {
            try
            {
                return context.Shippers.FirstOrDefault(r => r.ShipperID.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddShippers(Shippers shippers)
        {
            try
            {
                context.Shippers.Add(shippers);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateShippers(Shippers shippers)
        {
            try
            {
                context.Entry(shippers).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteShippers(Shippers shippers)
        {
            try
            {
                context.Shippers.Remove(shippers);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
