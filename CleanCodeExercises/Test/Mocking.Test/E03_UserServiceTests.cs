using Moq;
using ÖvningarMockning.Core.Services;
using ÖvningarMockning.Data.Interfaces;

namespace Mocking.Test;

public class E03_UserServiceTests
{
    private readonly Mock<IUserRepository> _userRepo;
    private readonly UserService _service;

    public E03_UserServiceTests()
    {
        _userRepo = new Mock<IUserRepository>();
        _service = new UserService(_userRepo.Object);
    }

    [Fact]
    public void IsAdmin_UserIsAdmin_ReturnsTrue()
    {
        string user = "Admin";
        _userRepo.Setup(x => x.GetRole(user)).Returns(user);
        var role = _userRepo.Object.GetRole(user);
        Assert.True(_service.IsAdmin(role));
    }


    [Theory]
    [InlineData("NonAdminUser")]
    [InlineData(null)]
    public void IsAdmin_UserIsNotAdminOrNull_ReturnsFalse(string? user)
    {
        Assert.False(_service.IsAdmin(user!));
    }
}
