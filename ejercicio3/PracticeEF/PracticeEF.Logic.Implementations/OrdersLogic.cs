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
    public class OrdersLogic : BaseLogic, ILogic<Orders>
    {
        
        public List<Orders> GetAll()
        {
            try
            {
                return context.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Orders GetOne(int id)
        {
            try
            {
                return context.Orders.FirstOrDefault(r => r.OrderID.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Orders orders)
        {
            try
            {
                context.Orders.Add(orders);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Orders orders)
        {
            try
            {
                context.Entry(orders).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Orders orders)
        {
            try
            {
                context.Orders.Remove(orders);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
