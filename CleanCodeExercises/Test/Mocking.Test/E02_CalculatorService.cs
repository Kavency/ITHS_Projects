using Moq;
using ÖvningarMockning.Core.Interfaces;
using ÖvningarMockning.Core.Services;

namespace Mocking.Test;

public class E02_CalculatorService
{
    private readonly Mock<ILogger> _mock;
    private readonly CalculatorService _service;

    public E02_CalculatorService()
    {
        _mock = new Mock<ILogger>();
        _service = new CalculatorService(_mock.Object);
    }


    [Fact]
    public void Add_AddTwoIntegers_LogsAndReturnsCorrectSum()
    {
        var result = _service.Add(1, 1);
        Assert.Equal(2, result);
        _mock.Verify(x => x.Log(It.Is<string>(s => s.Contains("Add: 1 + 1"))), Times.Once);
    }
}
