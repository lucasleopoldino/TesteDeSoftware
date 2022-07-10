using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            // Arrange
            var Calculadora = new Calculadora();

            // Act
            var resultado = Calculadora.Somar(2, 2);

            // Assert
            Assert.Equal(4, resultado);


        }

        [Fact]
        public void Calculadora_Dividir_RetornarValorDivisao()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Dividir(10, 5);

            // Assert
            Assert.Equal(2, resultado);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(9,5,14)]
        [InlineData(6,6,12)]
        [InlineData(8,7,15)]
        [InlineData(4,20,24)]
        public void Calculadora_Somar_RetornarNumeroCorreto(double a, double b, double total)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(a, b);

            // Assert
            Assert.Equal(total, resultado);
        }
    }
}
