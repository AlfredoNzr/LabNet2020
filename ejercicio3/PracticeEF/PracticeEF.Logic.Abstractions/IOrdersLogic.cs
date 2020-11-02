using PracticeEF.ResourceAccess.Entities;
using System.Collections.Generic;

namespace PracticeEF.Logic.Abstractions
{
    public interface IOrdersLogic
    {
        List<Orders> GetOrders();

        Orders GetOrders(int id);

        void AddOrders(Orders orders);

        void UpdateOrders(Orders orders);

        void DeleteOrders(Orders orders);
    }
}
