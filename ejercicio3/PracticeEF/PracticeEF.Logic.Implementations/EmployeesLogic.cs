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
    public class EmployeesLogic : BaseLogic, ILogic<Employees>
    {
        
        public List<Employees> GetAll()
        {
            try
            {
                return context.Employees.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employees GetOne(int id)
        {
            try
            {
                return context.Employees.FirstOrDefault(r => r.EmployeeID.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Insert(Employees employees)
        {
            try
            {
                context.Employees.Add(employees);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Employees employees)
        {
            try
            {
                context.Entry(employees).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Employees employees)
        {
            try
            {
                context.Employees.Remove(employees);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
