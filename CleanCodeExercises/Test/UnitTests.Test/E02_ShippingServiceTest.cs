using ÖvningarUnitTests.Core.Services;

namespace UnitTests.Test;

public class E02_ShippingServiceTest
{
    [Theory]
    [InlineData(-10, "A")]
    [InlineData(10, "Z")]
    public void CalculateShippingCost_InvalidArgumentsProvided_ThrowsArgumentException(double weightKg, string zone)
    {
        Assert.Throws<ArgumentException>(() => ShippingService.CalculateShippingCost(weightKg, zone));
    }

    [Theory]
    [InlineData(10, "A", 150.0)]
    [InlineData(10, "B", 220.0)]
    [InlineData(10, "C", 300.0)]
    public void CalculateShippingCost_ReturnsCorrectCost(double weightKg, string zone, double expectedResult)
    {
        var result = ShippingService.CalculateShippingCost(weightKg, zone);
        Assert.Equal(expectedResult, result);
    }
}
