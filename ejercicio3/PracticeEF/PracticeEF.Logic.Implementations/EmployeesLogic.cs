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
    public class EmployeesLogic : IEmployeesLogic
    {
        private readonly NorthwindContext context;

        public EmployeesLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Employees> GetEmployees()
        {
            try
            {
                return context.Employees.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Employees GetEmployees(int id)
        {
            try
            {
                return context.Employees.FirstOrDefault(r => r.EmployeeID.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddEmployees(Employees employees)
        {
            try
            {
                context.Employees.Add(employees);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateEmployees(Employees employees)
        {
            try
            {
                context.Entry(employees).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteEmployees(Employees employees)
        {
            try
            {
                context.Employees.Remove(employees);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
