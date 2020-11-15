using System;
using Xunit;

namespace DevopsExercise.Tests
{
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [Fact]
        public void AdditionTest()
        {
            //Arrange
            var x = 15;
            var y = 10;

            //Act
            var resultat = calculator.Addition(x, y);

            //Assert
            Assert.Equal(25, resultat);
        }
    }
}
