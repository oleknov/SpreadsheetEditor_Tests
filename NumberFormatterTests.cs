using SpreadsheetEditor.Core;

namespace SpreadsheetEditor.Tests;

public class NumberFormatterTests
{
    [Theory]
    [InlineData("123456789", "123456789")]
    [InlineData("1000000000", "1.000E+09")]
    [InlineData("-123456789", "-1.235E+08")]
    [InlineData("99995000000", "1.000E+11")] 
    public void Compact_UsesExponentFrom10Characters(string full, string expected)
    {
        Assert.Equal(expected, NumberFormatter.Compact(full));
    }
}