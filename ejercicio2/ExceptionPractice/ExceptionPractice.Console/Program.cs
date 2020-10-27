using ExceptionPractice.CrossCutting.Exceptions;
using ExceptionPractice.Logic.Implementations;
using System;

namespace ExceptionPractice.Interfaces.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            int menu = 0;
            Operations Operation = new Operations();
            do
            { 
                switch (menu)
                {
                    case 1:
                        {
                            try //Punto 1, ingresar un Valor, Dividir por cero y generar Excepcion
                            {
                                int number;
                                Console.WriteLine("Ingrese un Numero");
                                number = Convert.ToInt32(Console.ReadLine());
                                Operation.DivisionZero(number);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Mensaje error: " + ex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("La operacion se completo");
                            }
                            break;
                        }
                    case 2:
                        {
                            try //Punto 2, Ingresar 2 valores y generar excepciones en Division por Cero y en formato no valido
                            {
                                int number;
                                int numberTwo;
                                Console.WriteLine("Ingrese un Numero");
                                number = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese un Numero");
                                numberTwo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"La division es: {Operation.Division(number, numberTwo)}");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("La operacion finalizo");
                            }
                            break;
                        }
                    case 3:
                        {
                            try //Punto 3, generar excepcion y mostrar el Tipo de excepcion y el Mensaje
                            {
                                Operation.ExceptionGenerator();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("La operacion finalizo");
                            }
                            break;
                        }
                    case 4:
                        {
                            try //Punto 4, idem al anterior pero generando una Exception personalizada
                            {
                                Operation.CustomExceptionGenerator();
                            }
                            catch (CustomException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("La operacion finalizo");
                            }
                            break;
                        }
                }

                ShowMenu();
                menu = Convert.ToInt32(Console.ReadLine()); //Exception no capturada

            } while (menu != 0);
            
        }

        private static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("OPCIONES");
            Console.WriteLine("1) DivideByZeroException");
            Console.WriteLine("2) DivideByZeroException y FormatException");
            Console.WriteLine("3) Usando Logic");
            Console.WriteLine("4) Usando Logic y CustomException");
            Console.WriteLine("0) Finalizar");
        }
    }
}
