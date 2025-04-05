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

    private static string Minesweeper(string s)
    {
        if (s == ".")
            return "0";

        return s;
    }
}