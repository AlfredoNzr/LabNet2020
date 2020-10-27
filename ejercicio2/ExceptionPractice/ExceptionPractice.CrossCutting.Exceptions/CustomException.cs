using System;

namespace ExceptionPractice.CrossCutting.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base($"Excepcion Personalizada. {message}")
        {

        }
    }
}
