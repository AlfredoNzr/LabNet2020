using PracticeEF.Logic.Implementations;
using PracticeEF.ResourceAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEF.Interfaces.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = Menu();
            while (menu != 0)
            {
                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine("------ EMPLEADOS -------");
                            EmployeesLogic employeesLogic = new EmployeesLogic();

                            List<Employees> employees = employeesLogic.GetAll();

                            foreach (Employees e in employees)
                            {
                                Console.WriteLine($"ID: {e.EmployeeID}  -- Name: {e.FirstName} -- Last Name: {e.LastName}");
                            }

                            int menuEmployees = MenuExtra();
                            while(menuEmployees != 0)
                            {
                                switch (menuEmployees)
                                {
                                    case 1:
                                        {
                                            try
                                            {
                                                Console.WriteLine("Datos del nuevo Empleado");
                                                Console.WriteLine("Nombre del Empleado");
                                                string nameEmployee = Convert.ToString(Console.ReadLine());
                                                Console.WriteLine("Apellido del Empleado");
                                                string lastnameEmployee = Convert.ToString(Console.ReadLine());
                                                Employees employeesInsert = new Employees();
                                                employeesInsert.FirstName = nameEmployee;
                                                employeesInsert.LastName = lastnameEmployee;
                                                employeesLogic.Insert(employeesInsert);
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine($"No se pudo insertar el nuevo Empleado. Error: {ex.Message}");
                                            }
                                            break;
                                        }
                                        
                                    case 2:
                                        {
                                            try
                                            {
                                                Console.WriteLine("Ingrese el ID  de Empleado a eliminar");
                                                Employees employeesDel = employeesLogic.GetOne(Convert.ToInt32(Console.ReadLine()));
                                                employeesLogic.Delete(employeesDel);
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine($"No se pudo eliminar el Empleado. Error: {ex.Message}");
                                            }
                                            break;
                                        }
                                }
                                Console.WriteLine();
                                menuEmployees = MenuExtra();
                            }

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("------ CATEGORIAS -------");

                            CategoriesLogic categoriesLogic = new CategoriesLogic();

                            List<Categories> categories = categoriesLogic.GetAll();

                            foreach (Categories c in categories)
                            {
                                Console.WriteLine($"ID: {c.CategoryID}  -- Name: {c.CategoryName} -- Description: {c.Description}");
                            }

                            int menuCategories = MenuExtra();
                            
                            while(menuCategories != 0)
                            {
                                switch (menuCategories)
                                {
                                    case 1:
                                        {
                                            try
                                            {
                                                Console.WriteLine("Datos de la nueva Categoria");
                                                Console.WriteLine("Nombre de la Categoria");
                                                string nameCategory = Convert.ToString(Console.ReadLine());
                                                Console.WriteLine("Descripcion de la Categoria");
                                                string descriptionCategory = Convert.ToString(Console.ReadLine());
                                                Categories categoriesInsert = new Categories();
                                                categoriesInsert.CategoryName = nameCategory;
                                                categoriesInsert.Description = descriptionCategory;
                                                categoriesLogic.Insert(categoriesInsert);
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine($"No se pudo insertar la nueva Categoria. Error: {ex.Message}");
                                            }
                                            break;
                                        }

                                    case 2:
                                        {
                                            try
                                            {
                                                Console.WriteLine("Ingrese el ID de la Categoria a eliminar");
                                                Categories categoriesDel = categoriesLogic.GetOne(Convert.ToInt32(Console.ReadLine()));
                                                categoriesLogic.Delete(categoriesDel);
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine($"No se pudo eliminar la Categoria. Error: {ex.Message}");
                                            }
                                            break;
                                        }
                                    case 0:
                                        break;
                                }
                                Console.WriteLine();
                                menuCategories = MenuExtra();
                            } 

                            break;
                        } 
                    case 0: break;
                    
                }
                Console.WriteLine();
                menu = Menu();
            }

        }

        static int Menu()
        {
            try
            {
                Console.WriteLine("1) Empleados");
                Console.WriteLine("2) Categorias");
                Console.WriteLine("0) Salir");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }
        }

        static int MenuExtra()
        {
            try
            {
                Console.WriteLine("1) Agregar");
                Console.WriteLine("2) Eliminar");
                Console.WriteLine("0) Salir");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
