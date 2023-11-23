
using CorridaDeCachorros;
using Xunit;
using FluentAssertions;

namespace CorridaDeCachorros.Tests
{

    public class Corredor4Tests
    {
        [Fact]
        public void MoverTest()
        {
            //Arrange
            var corredor = new Corredor4(1);
            double distanciaEsperadaMaiorQue = 0.3;
            double distanciaEsperadaMenorQue = 0.5;
            //Act
            corredor.Mover();

            //Assert
            corredor.DistanciaPercorrida().Should().BeGreaterThanOrEqualTo(distanciaEsperadaMaiorQue);
            corredor.DistanciaPercorrida().Should().BeLessThanOrEqualTo(distanciaEsperadaMenorQue);
            
        }
    }
}