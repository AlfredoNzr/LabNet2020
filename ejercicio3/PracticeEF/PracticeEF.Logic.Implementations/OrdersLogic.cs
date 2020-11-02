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
    public class OrdersLogic : IOrdersLogic
    {
        private readonly NorthwindContext context;

        public OrdersLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Orders> GetOrders()
        {
            try
            {
                return context.Orders.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Orders GetOrders(int id)
        {
            try
            {
                return context.Orders.FirstOrDefault(r => r.OrderID.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddOrders(Orders orders)
        {
            try
            {
                context.Orders.Add(orders);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateOrders(Orders orders)
        {
            try
            {
                context.Entry(orders).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteOrders(Orders orders)
        {
            try
            {
                context.Orders.Remove(orders);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
