using CorridaDeCachorros;
using Xunit;
using FluentAssertions;

namespace CorridaDeCachorros.Tests;

public class Corredor2Tests
{
    [Fact]
    public void MoverTest()
    {
        //Arrange
        var corredor = new Corredor2(1);
        double distanciaEsperadaMaiorQue = 0.0;
        double distanciaEsperadaMenorQue = 0.7;

        //Act
        corredor.Mover();

        //Assert
        corredor.DistanciaPercorrida().Should().BeGreaterThanOrEqualTo(distanciaEsperadaMaiorQue);
        corredor.DistanciaPercorrida().Should().BeLessThanOrEqualTo(distanciaEsperadaMenorQue);
    }
}