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
    public class OrdersLogic : IOrdersLogic
    {
        private readonly NorthwindContext context;

        public OrdersLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Orders> GetOrders()
=======
    public class OrdersLogic : BaseLogic, ILogic<Orders>
    {
        
        public List<Orders> GetAll()
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Orders.ToList();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public Orders GetOrders(int id)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Orders GetOne(int id)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Orders.FirstOrDefault(r => r.OrderID.Equals(id));
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void AddOrders(Orders orders)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Orders orders)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Orders.Add(orders);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateOrders(Orders orders)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Orders orders)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Entry(orders).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteOrders(Orders orders)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Orders orders)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Orders.Remove(orders);
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
