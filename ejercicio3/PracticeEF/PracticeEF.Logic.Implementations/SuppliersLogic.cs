using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeEF.Logic.Implementations
{
    public class SuppliersLogic : ISuppliersLogic
    {
        private readonly NorthwindContext context;

        public SuppliersLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Suppliers> GetSuppliers()
        {
            try
            {
                return context.Suppliers.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Suppliers GetSuppliers(int id)
        {
            try
            {
                return context.Suppliers.FirstOrDefault(r => r.SupplierID.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddSuppliers(Suppliers suppliers)
        {
            try
            {
                context.Suppliers.Add(suppliers);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateSuppliers(Suppliers suppliers)
        {
            try
            {
                context.Entry(suppliers).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteSuppliers(Suppliers suppliers)
        {
            try
            {
                context.Suppliers.Remove(suppliers);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
