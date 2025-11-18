using ÖvningarUnitTests.Helpers;

namespace UnitTests.Test;

public class E06_PasswordValidatorTest
{
    [Fact]
    public void IsStrongPassword_StrongPasswordEntered_ReturnsTrue()
    {
        var password = "AB12opk!";
        var result = PasswordValidator.IsStrongPassword(password);
        Assert.True(result);
    }


    [Theory]
    [InlineData("AAbb1122")]
    [InlineData("AAbb!!@@")]
    [InlineData("Ab1!")]
    [InlineData("!#¤%%¤#!")]
    [InlineData(null)]
    public void IsStrongPassword_WeakPasswordEntered_ReturnsFalse(string? password)
    {
        var result = PasswordValidator.IsStrongPassword(password!);
        Assert.False(result);
    }
}
