using SpreadsheetEditor.Core;

namespace SpreadsheetEditor.Tests;

public class ErrorTests
{
    [Theory]
    [InlineData("1/0")]     
    [InlineData("(1+2")]    
    [InlineData("1 2")]   
    public void InvalidExpression_ShowsError(string expression)
    {
        var cell = TestTable.Evaluate(expression);

        Assert.NotNull(cell.Error);
        Assert.Equal("#ПОМИЛКА", cell.GetDisplayText(ViewMode.Value));
    }
}