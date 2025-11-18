using ÖvningarUnitTests.Core.Services;

namespace UnitTests.Test;

public class E07_GradeServiceTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 5, "Fail")]
    [InlineData(new int[] { 1, 2, 3 }, 100, "Pass")]
    [InlineData(new int[] { 50, 50, 50 }, 100, "Pass with Distinction")]
    public void CalculateFinalGrade_ReturnsStringWithGrade(int[] assignmentPoints, int examPoints, string expected)
    {
        var result = GradeService.CalculateFinalGrade(assignmentPoints, examPoints);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, -5)]
    public void CalculateFinalGrade_ExamPointsOutOfRange_ThrowsArgumentException(int[] assignmentPoints, int examPoints)
    {
        var exception = Assert.Throws<ArgumentException>(() => GradeService.CalculateFinalGrade(assignmentPoints, examPoints));
    }

    [Theory]
    [InlineData(new int[] { -1, -2, -3 }, 5)]
    public void CalculateFinalGrade_AssignmentPointsOutOfRange_ThrowsArgumentException(int[] assignmentPoints, int examPoints)
    {
        var exception = Assert.Throws<ArgumentException>(() => GradeService.CalculateFinalGrade(assignmentPoints, examPoints));
    }
}
