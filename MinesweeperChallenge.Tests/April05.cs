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
public class April05
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

    private static string Minesweeper(string s)
    {
        if (!s.Contains("."))
            return s;
        if (s == "*.")
            return "*1";

        return string.Join(string.Empty, Enumerable.Repeat("0", s.Length));
    }
}