using System.Numerics;

namespace SpreadsheetEditor.Tests;

public class OperationTests
{
    [Theory]
    [InlineData("2+3*4", 14)]
    [InlineData("(2+3)*4", 20)]
    [InlineData("2^3^2", 512)]
    [InlineData("-2^2", -4)]
    [InlineData("7/2", 4)]
    [InlineData("inc(5)*dec(3)", 12)]
    public void Evaluate_CalculatesVariantOperationsWithPriority(string expression, int expected)
    {
        var cell = TestTable.Evaluate(expression);

        Assert.Null(cell.Error);
        Assert.Equal(new BigInteger(expected), cell.Value);
    }
}   