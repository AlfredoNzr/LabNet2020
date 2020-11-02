using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeEF.ResourceAccess.Entities;

namespace PracticeEF.Logic.Abstractions
{
    public interface IEmployeesLogic
    {
        List<Employees> GetEmployees();
        
        Employees GetEmployees(int id);
        
        void AddEmployees(Employees employees);


        void UpdateEmployees(Employees employees);
        
        void DeleteEmployees(Employees employees);
        
    }
}
