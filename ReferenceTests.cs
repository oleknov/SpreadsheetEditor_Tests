using System.Numerics;
using SpreadsheetEditor.Core;

namespace SpreadsheetEditor.Tests;

public class ReferenceTests
{
    [Fact]
    public void Reference_IsRecalculatedWhenReferencedCellChanges()
    {
        var table = new Spreadsheet(3, 3);
        table.SetCellExpression(0, 0, "5");   
        table.SetCellExpression(0, 1, "A1*2");

        Assert.Equal(new BigInteger(10), table.GetCell(0, 1).Value);

        table.SetCellExpression(0, 0, "7");

        Assert.Equal(new BigInteger(14), table.GetCell(0, 1).Value);
    }
}