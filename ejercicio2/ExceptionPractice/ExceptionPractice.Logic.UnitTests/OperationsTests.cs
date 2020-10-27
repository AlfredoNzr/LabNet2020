using System;
using ExceptionPractice.CrossCutting.Exceptions;
using ExceptionPractice.Logic.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExceptionPractice.Logic.UnitTests
{
    [TestClass]
    public class OperationsTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionZero_ExpectedException_Test()
        {
            var Operation = new Operations();

            Operation.DivisionZero(1);
        }

        [TestMethod]
        public void Division_Test()
        {
            //Arrange
            int number = 4;
            int numberTwo = 2;
            int result = 2;

            var Operation = new Operations();

            //Act
            double division = Operation.Division(number, numberTwo);

            //Assert
            Assert.AreEqual(result, division);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Division_ArgumentException_Test()
        {
            int number = 4;
            int numberTwo = 0;

            var Operation = new Operations();

            Operation.Division(number, numberTwo);
        }

        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void CustomExceptionGenerator_Test()
        {
            var Operation = new Operations();

            Operation.CustomExceptionGenerator();
        }
    }
}
