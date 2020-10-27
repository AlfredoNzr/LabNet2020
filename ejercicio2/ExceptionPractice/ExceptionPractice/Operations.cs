using System;
using ExceptionPractice.CrossCutting.Exceptions;
using ExceptionPractice.CrossCutting.ExtensionMethods;
using ExceptionPractice.Logic.Abstractions;

namespace ExceptionPractice.Logic.Implementations
{
    public class Operations : IOperations
    {
        public double DivisionZero(int number)
        {
            try
            {
                return number / 0;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
        public double Division(int number, int numberTwo) //Punto 2
        {
            try
            {
                return number / numberTwo;
            }
            catch (DivideByZeroException ex)
            {
                throw new ArgumentException($"Solo John Wick divide por cero!!! {ex.Message}");
            }
        }

        public Exception ExceptionGenerator() //Punto 3
        {
            try
            {
                throw new DivideByZeroException();
                
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"{ex.GetType().Name}. {ex.Message.CrazyCamelCase()}");
            }
        }

        public CustomException CustomExceptionGenerator() //Punto 4
        {
            try
            {
                throw new CustomException("Excepcion personalizada".CrazyCamelCase());
            }
            catch (Exception)
            {
                throw new CustomException("Habia una vez".CrazyCamelCase());

            }
        }
    }
}
