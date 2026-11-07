using SpreadsheetEditor.Core;

namespace SpreadsheetEditor.Tests;

internal static class TestTable
{
    public static Cell Evaluate(string expression)
    {
        var table = new Spreadsheet(3, 3);
        table.SetCellExpression(0, 0, expression);
        return table.GetCell(0, 0);
    }
}