using ConsoleP;
using Xunit;

namespace Test
{
    public class CalculatorTest
    {
        [Fact] //Se convierte en prueba unitaria
        public void Sum()
        {
            // Modelo de las AAA

            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Sum(2, 3);

            //Assert
            Assert.Equal(5, result);
        }
    }
}
