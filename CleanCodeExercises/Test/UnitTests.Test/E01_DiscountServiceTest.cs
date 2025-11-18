using ÖvningarUnitTests.Core.Services;

namespace UnitTests.Test;

public class E01_DiscountServiceTest
{
    [Theory]
    [InlineData(-10.0, 25, false)]
    public void CalculateDiscountedPrice_OriganalPriceOutOfBounds_ThrowsArgumentExcemption(decimal originalPrice, int customerAge, bool hasMembership)
    {
        Assert.Throws<ArgumentException>(()=> DiscountService.CalculateDiscountedPrice(originalPrice, customerAge, hasMembership));
    }

    [Theory]
    [InlineData(10.0, 25, true, 0.1)]
    [InlineData(10.0, 65, true, 0.15)]
    [InlineData(10.0, 65, false, 0.05)]
    [InlineData(10.0, 25, false, 0.0)]
    public void CalculateDiscountedPrice_ReturnsDiscountedPrice(decimal originalPrice, int customerAge, bool hasMembership, decimal expectedDiscount)
    {
        var discountedPrice = DiscountService.CalculateDiscountedPrice(originalPrice, customerAge, hasMembership);
        Assert.Equal(originalPrice * (1 - expectedDiscount), discountedPrice);
    }
}
