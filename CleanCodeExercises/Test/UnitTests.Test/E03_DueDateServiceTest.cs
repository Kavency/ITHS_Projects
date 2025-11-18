using ÖvningarUnitTests.Core.Services;

namespace UnitTests.Test;

public class E03_DueDateServiceTest
{
    [Theory]
    [InlineData(new int[]{ 2024, 1, 31 }, new int[]{ 2024, 1, 1 }, 30)]
    [InlineData(new int[]{ 2024, 1, 1 }, new int[]{ 2024, 1, 1 }, 0)]
    [InlineData(new int[]{ 2024, 1, 1 }, new int[]{ 2024, 1, 2 }, 0)]
    public void DaysUntilDue_ReturnsCorrectNumberOfDays(int[] date1, int[] date2, int expected)
    {
        DateTime dueDate = new DateTime(date1[0], date1[1], date1[2]);
        DateTime today = new DateTime(date2[0], date2[1], date2[2]);
        
        var result = DueDateService.DaysUntilDue(dueDate, today);

        Assert.Equal(expected, result);
    }
}
