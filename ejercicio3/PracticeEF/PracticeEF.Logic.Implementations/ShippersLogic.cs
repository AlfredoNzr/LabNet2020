using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeEF.Logic.Implementations
{
    public class ShippersLogic : BaseLogic, ILogic<Shippers>
    {

        public List<Shippers> GetAll()
        {
            try
            {
                return context.Shippers.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Shippers GetOne(int id)
        {
            try
            {
                return context.Shippers.FirstOrDefault(r => r.ShipperID.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Modify(Shippers shippers)
        {
            try
            {
                context.Shippers.Add(shippers);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Shippers shippers)
        {
            try
            {
                context.Entry(shippers).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Shippers shippers)
        {
            try
            {
                context.Shippers.Remove(shippers);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Shippers entity)
        {
            throw new NotImplementedException();
        }
    }
}
