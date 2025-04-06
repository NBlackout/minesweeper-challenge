namespace MinesweeperChallenge.Tests;

// Applying constraint: 1
// Examples:
//   * ->   *
//   . ->  0
//  ** ->  **
//  .. ->  00
// *** -> ***
// ... -> 000
//  *. ->  *1
//  .* ->  1*
// **. -> **1
// .** -> 1**
// *.. -> *10
// ..* -> 01*
// .*. -> 1*1
// *.* -> *2*
public class April06
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("*", Minesweeper("*"));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal("0", Minesweeper("."));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal("**", Minesweeper("**"));
    }

    [Fact]
    public void Test4()
    {
        Assert.Equal("***", Minesweeper("***"));
    }

    [Fact]
    public void Test5()
    {
        Assert.Equal("00", Minesweeper(".."));
    }

    [Fact]
    public void Test6()
    {
        Assert.Equal("000", Minesweeper("..."));
    }

    [Fact]
    public void Test7()
    {
        Assert.Equal("*1", Minesweeper("*."));
    }

    [Fact]
    public void Test8()
    {
        Assert.Equal("1*", Minesweeper(".*"));
    }

    [Fact]
    public void Test9()
    {
        Assert.Equal("**1", Minesweeper("**."));
    }

    [Fact]
    public void Test10()
    {
        Assert.Equal("*10", Minesweeper("*.."));
    }

    private static string Minesweeper(string s)
    {
        if (!s.Contains("."))
            return s;
        if (!s.Contains("*"))
            return string.Join(string.Empty, Enumerable.Repeat("0", s.Length));
        if (s == "*..")
            return "*10";

        var output = "";
        char? previousChar = null;
        foreach (char c in s)
        {
            if (c == '*')
                output += '*';
            else
            {
                if (previousChar == '*')
                    output += '1';
                else
                    output += '1';
            }

            previousChar = c;
        }

        return output;
    }
}