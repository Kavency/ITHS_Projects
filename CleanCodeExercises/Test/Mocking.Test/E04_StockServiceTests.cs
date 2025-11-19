using Mocking.Core.Interfaces;
using Mocking.Core.Services;
using Moq;
using ÖvningarMockning.Data.Interfaces;

namespace Mocking.Test;

public class E04_StockServiceTests
{
    private readonly Mock<IInventoryRepository> _mockRepo;
    private readonly IStockService _service;
    private string _productId = "1";
    
    public E04_StockServiceTests()
    {
        _mockRepo = new Mock<IInventoryRepository>();
        _service = new StockService(_mockRepo.Object);
    }


    [Fact]
    public void HasEnoughStock_ReturnsTrue()
    {
        int amount = 1;
        int inStock = 5;
        _mockRepo.Setup(x => x.GetStock(It.IsAny<string>())).Returns(inStock);
        var result = _service.HasEnoughStock(_productId, amount);
        Assert.True(result);
        _mockRepo.Verify(x => x.GetStock(_productId), Times.Once);
    }


    [Fact]
    public void HasEnoughStock_ReturnsFalse()
    {
        var amount = 5;
        var inStock = 1;
        _mockRepo.Setup(x => x.GetStock(It.IsAny<string>())).Returns(inStock);
        var result = _service.HasEnoughStock(_productId, amount);
        Assert.False(result);
        _mockRepo.Verify(x => x.GetStock(_productId), Times.Once);
    }
}
