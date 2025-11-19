namespace Mocking.Core.Interfaces;

public interface IStockService
{
    bool HasEnoughStock(string productId, int requiredQuantity);
}
