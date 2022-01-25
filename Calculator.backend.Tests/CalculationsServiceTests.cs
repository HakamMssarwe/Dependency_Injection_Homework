using Calculator.backend.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.backend.Tests
{
    [TestClass]
    public class CalculationsServiceTests
    {
        [TestMethod]
        [DataRow(1,2)]
        [DataRow(5,7)]
        [DataRow(2,10)]
        public void Add_AddTwoNumbers_ReturnSum(double numberOne, double numberTwo)
        {
            //Arrange
            var calculationsService = new CalculationsService();

            //Act
            var result = calculationsService.Add(numberOne, numberTwo);


            //Assert
            Assert.AreEqual(numberOne + numberTwo, result);
        }


        [TestMethod]
        [DataRow(1, 2)]
        [DataRow(5, 7)]
        [DataRow(2, 10)]
        public void Substract_SubstractTwoNumbers_ReturnSum(double numberOne, double numberTwo)
        {
            //Arrange 
            var calculationsService = new CalculationsService();

            //Act
            var result = calculationsService.Substract(numberOne, numberTwo);

            //Assert
            Assert.AreEqual(numberOne - numberTwo, result);
        }


        [TestMethod]
        [DataRow(1, 2)]
        [DataRow(5, 7)]
        [DataRow(2, 10)]
        public void Multiply_MultiplyTwoNumbers_ReturnSum(double numberOne, double numberTwo)
        {
            //Arrange
            var calculationsService = new CalculationsService();

            //Act
            var result = calculationsService.Multiply(numberOne, numberTwo);

            //Assert
            Assert.AreEqual(numberOne, numberTwo, result);
        }


        [TestMethod]
        [DataRow(1, 2)]
        [DataRow(5, 7)]
        [DataRow(2, 10)]
        public void Divide_DivideTwoNumbers_ReturnSum(double numberOne, double numberTwo)
        {
            //Arrange
            var calculationsService = new CalculationsService();

            //Act
            var result = calculationsService.Divide(numberOne, numberTwo);

            //Assert
            Assert.AreEqual(numberOne / numberTwo, result);
        }
    }
}
