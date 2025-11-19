using Mocking.Core.Interfaces;
using ÖvningarMockning.Data.Interfaces;

namespace Mocking.Core.Services;

public class StockService(IInventoryRepository _repo) : IStockService
{
    public bool HasEnoughStock(string productId, int requiredQuantity)
    {
        var stock = _repo.GetStock(productId);

        if (requiredQuantity <= stock)
            return true;
        
        return false;
    }
}
