using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeEF.Logic.Implementations
{
    public class SuppliersLogic : BaseLogic, ILogic<Suppliers>
    {

        public List<Suppliers> GetAll()
        {
            try
            {
                return context.Suppliers.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Suppliers GetOne(int id)
        {
            try
            {
                return context.Suppliers.FirstOrDefault(r => r.SupplierID.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Suppliers suppliers)
        {
            try
            {
                context.Suppliers.Add(suppliers);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Suppliers suppliers)
        {
            try
            {
                context.Entry(suppliers).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Suppliers suppliers)
        {
            try
            {
                context.Suppliers.Remove(suppliers);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
