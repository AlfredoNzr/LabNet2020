using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeEF.Logic.Implementations
{
<<<<<<< HEAD
    public class SuppliersLogic : ISuppliersLogic
    {
        private readonly NorthwindContext context;

        public SuppliersLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Suppliers> GetSuppliers()
=======
    public class SuppliersLogic : BaseLogic, ILogic<Suppliers>
    {

        public List<Suppliers> GetAll()
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Suppliers.ToList();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public Suppliers GetSuppliers(int id)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Suppliers GetOne(int id)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Suppliers.FirstOrDefault(r => r.SupplierID.Equals(id));
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void AddSuppliers(Suppliers suppliers)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Suppliers suppliers)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Suppliers.Add(suppliers);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateSuppliers(Suppliers suppliers)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Suppliers suppliers)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Entry(suppliers).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteSuppliers(Suppliers suppliers)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Suppliers suppliers)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Suppliers.Remove(suppliers);
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
