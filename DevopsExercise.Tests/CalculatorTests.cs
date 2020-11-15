using DevopsExercise.Web.Repository;
using Xunit;

namespace DevopsExercise.Tests
{
    public class CalculatorTests
    {
        CalculatorRepository calculator = new CalculatorRepository();

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
