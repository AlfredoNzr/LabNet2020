using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeEF.ResourceAccess.Entities;

namespace PracticeEF.Logic.Abstractions
{
    public interface ICustomersLogic
    {
        List<Customers> GetCustomers();

        Customers GetCustomers(int id);

        void AddCustomers(Customers customers);

        void UpdateCustomers(Customers customers);
        
    }
}
