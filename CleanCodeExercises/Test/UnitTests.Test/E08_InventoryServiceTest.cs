using ÖvningarUnitTests.Core.Services;

namespace UnitTests.Test;

public class E08_InventoryServiceTest
{
    [Fact]
    public void AddStock_AddItemToStock()
    {
        string item = "item";
        int amount = 5;
        var service = new InventoryServcie();

        service.AddStock(item, amount);
        
        var result = service.GetStock(item);

        Assert.Equal(amount, result);
    }


    [Fact]
    public void RemoveStock_RemoveItemFromStock()
    {
        string item = "item";
        int amount = 5;
        int amountToRemove = 5;
        var service = new InventoryServcie();

        service.AddStock(item, amount);
        service.RemoveStock(item, amountToRemove);
        
        var result = service.GetStock(item);

        Assert.Equal(amount - amountToRemove, result);
    }


    [Fact]
    public void RemoveStock_RemoveMoreThanInStock_ThrowsInvalidOperationException()
    {
        string item = "item";
        int amount = 5;
        int amountToRemove = 15;
        var service = new InventoryServcie();

        service.AddStock(item, amount);

        Assert.Throws<InvalidOperationException>(() => service.RemoveStock(item, amountToRemove));
    }
}
