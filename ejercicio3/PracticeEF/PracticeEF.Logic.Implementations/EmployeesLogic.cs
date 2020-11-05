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
    public class EmployeesLogic : IEmployeesLogic
    {
        private readonly NorthwindContext context;

        public EmployeesLogic()
        {
            this.context = new NorthwindContext();
        }

        public List<Employees> GetEmployees()
=======
    public class EmployeesLogic : BaseLogic, ILogic<Employees>
    {
        
        public List<Employees> GetAll()
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Employees.ToList();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public Employees GetEmployees(int id)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employees GetOne(int id)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                return context.Employees.FirstOrDefault(r => r.EmployeeID.Equals(id));
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }
        public void AddEmployees(Employees employees)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Insert(Employees employees)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Employees.Add(employees);
                context.SaveChanges();
            }
<<<<<<< HEAD
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateEmployees(Employees employees)
=======
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Employees employees)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Entry(employees).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                throw;
            }
        }

        public void DeleteEmployees(Employees employees)
=======
                throw ex;
            }
        }

        public void Delete(Employees employees)
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
        {
            try
            {
                context.Employees.Remove(employees);
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
