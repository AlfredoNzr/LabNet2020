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

<<<<<<< HEAD
                            List<Employees> employees = employeesLogic.GetEmployees();
=======
                            List<Employees> employees = employeesLogic.GetAll();
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0

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
<<<<<<< HEAD
                                                employeesLogic.AddEmployees(employeesInsert);
=======
                                                employeesLogic.Insert(employeesInsert);
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
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
<<<<<<< HEAD
                                                Employees employeesDel = employeesLogic.GetEmployees(Convert.ToInt32(Console.ReadLine()));
                                                employeesLogic.DeleteEmployees(employeesDel);
=======
                                                Employees employeesDel = employeesLogic.GetOne(Convert.ToInt32(Console.ReadLine()));
                                                employeesLogic.Delete(employeesDel);
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
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

<<<<<<< HEAD
                            List<Categories> categories = categoriesLogic.GetCategories();
=======
                            List<Categories> categories = categoriesLogic.GetAll();
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0

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
<<<<<<< HEAD
                                                categoriesLogic.AddCategories(categoriesInsert);
=======
                                                categoriesLogic.Insert(categoriesInsert);
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
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
<<<<<<< HEAD
                                                Categories categoriesDel = categoriesLogic.GetCategories(Convert.ToInt32(Console.ReadLine()));
                                                categoriesLogic.DeleteCategories(categoriesDel);
=======
                                                Categories categoriesDel = categoriesLogic.GetOne(Convert.ToInt32(Console.ReadLine()));
                                                categoriesLogic.Delete(categoriesDel);
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
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

<<<<<<< HEAD
            //try
            //{
            //    RegionLogic regionLogic = new RegionLogic();
            //    var region = regionLogic.GetRegion(2);

            //        Console.WriteLine(region.RegionDescription);

            //    ShippersLogic shippersLogic = new ShippersLogic();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //RegionLogic regionLogic = new RegionLogic();
            //Region region = new Region();
            //region.RegionID = 6;
            //region.RegionDescription = "ASD";
            //regionLogic.AddRegion(region);

            //Region region = regionLogic.GetRegion(6);
            //regionLogic.DeleteRegion(region);
            
            //CategoriesLogic categoriesLogic = new CategoriesLogic();
            //Categories categories = new Categories();

            //Categories categories = categoriesLogic.GetCategories(1);
            //categories.CategoryID = 1;
            //categories.CategoryName = "BeverageZZZ";
            //categoriesLogic.UpdateCategories(categories);
            //Console.WriteLine(categories.CategoryName);

            //CategoriesLogic categoriesLogic = new CategoriesLogic();
            //Categories categories = categoriesLogic.GetCategories(1);
            //Console.WriteLine(categories.CategoryName);
            //try
            //{
            //    categoriesLogic.DeleteCategories(categories);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Ocurrio un error {ex.Message}");
            //}


            //CustomersLogic customersLogic = new CustomersLogic();
            ///*Customers customers = customersLogic.GetCustomers(1);*/ //Trae un solo Customer

            //List<Customers> lstCustomers = customersLogic.GetCustomers();
            //foreach (Customers c in lstCustomers)
            //{
            //    Console.WriteLine($"{c.CustomerID} -- {c.ContactName} -- {c.Address}");
            //}

=======
>>>>>>> 0648de9a2e6129d2c3cb99b1f1c25f8d7688b8b0
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
