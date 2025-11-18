using ÖvningarUnitTests.Helpers;

namespace UnitTests.Test;

public class E04_SsnValidatorTest
{
    [Theory]
    [InlineData("199001014324")]
    public void IsValidSwedishPersonnummer_ValidSsnProvided_ReturnsTrue(string ssn)
    {
        var result = PersonnummerValidator.IsValidSwedishPersonnummer(ssn);
        Assert.True(result);
    }

    [Theory]
    [InlineData("199015014321")]
    [InlineData("1990")]
    [InlineData("19900101ABCD")]
    [InlineData("199001014321")]
    public void IsValidSwedishPersonnummer_InvalidSsnProvided_ReturnsFalse(string ssn)
    {
        var result = PersonnummerValidator.IsValidSwedishPersonnummer(ssn);
        Assert.False(result);
    }
}
