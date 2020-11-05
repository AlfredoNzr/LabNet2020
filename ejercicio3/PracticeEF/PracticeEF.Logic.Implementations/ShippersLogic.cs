using PracticeEF.Logic.Abstractions;
using PracticeEF.ResourceAccess.DataBase;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeEF.Logic.Implementations
{
<<<<<<< HEAD
    public class ShippersLogic : IShippersLogic
    {
        private readonly NorthwindContext context;

        public ShippersLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Shippers> GetShippers()
=======
    public class ShippersLogic : BaseLogic, ILogic<Shippers>
    {

        public List<Shippers> GetAll()
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Shippers.ToList();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public Shippers GetShippers(int id)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Shippers GetOne(int id)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Shippers.FirstOrDefault(r => r.ShipperID.Equals(id));
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }
        public void AddShippers(Shippers shippers)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Modify(Shippers shippers)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Shippers.Add(shippers);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateShippers(Shippers shippers)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Shippers shippers)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Entry(shippers).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteShippers(Shippers shippers)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Shippers shippers)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Shippers.Remove(shippers);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Shippers entity)
        {
            throw new NotImplementedException();
        }
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
    }
}
