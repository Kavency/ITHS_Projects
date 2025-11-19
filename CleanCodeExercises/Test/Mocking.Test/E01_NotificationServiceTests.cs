using Moq;
using ÖvningarMockning.Core.Interfaces;
using ÖvningarMockning.Core.Services;

namespace Mocking.Test;

public class E01_NotificationServiceTests
{
    private readonly Mock<IMessenger> _mock;
    private readonly NotificationService _service;

    public E01_NotificationServiceTests()
    {
        _mock = new Mock<IMessenger>();
        _service = new NotificationService(_mock.Object);
    }


    [Fact]
    public void NotifyUser_SendMessageOnce()
    {
        _service.NotifyUser("1234", "Hello World!");
        _mock.Verify(x => x.SendMessage("1234", "Hello World!"), Times.Once);
    }


    [Theory]
    [InlineData("")]
    [InlineData("     ")]
    [InlineData(null)]
    public void NotifyUser_MessageStringsIsEmpty_ReturnsWithoutSendingMessage(string? message)
    {
        _service.NotifyUser("1234", message!);
        _mock.Verify(x => x.SendMessage("1234", message!), Times.Never);
    }
}
