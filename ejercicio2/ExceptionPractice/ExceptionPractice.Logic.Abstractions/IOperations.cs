using ExceptionPractice.CrossCutting.Exceptions;
using System;

namespace ExceptionPractice.Logic.Abstractions
{
    public interface IOperations
    {
        double DivisionZero(int number);

        double Division(int number, int numberTwo);

        Exception ExceptionGenerator();

        CustomException CustomExceptionGenerator();
    }
}
