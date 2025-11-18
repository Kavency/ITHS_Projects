using ÖvningarUnitTests.Core.Services;

namespace UnitTests.Test;

public class E05_InterestServiceTest
{
    [Theory]
    [InlineData(1000, 5, 365, 50.0)]
    [InlineData(1000, 5, 0, 0.0)]
    public void CalculateInterest_ValidArgumentsProvided_ReturnsResult(decimal balance, decimal annualPercentageRate, int days, decimal expected)
    {
        var result = InterestService.CalculateInterest(balance, annualPercentageRate, days);
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData(-1000, 5, 365, 50.0)]
    [InlineData(1000, -5, 365, 0.0)]
    public void CalculateInterest_InvalidArgumentsProvided_ThrowsArgumentException(decimal balance, decimal annualPercentageRate, int days, decimal expected)
    {
        Assert.Throws<ArgumentException>(() => InterestService.CalculateInterest(balance, annualPercentageRate, days));
    }
}
