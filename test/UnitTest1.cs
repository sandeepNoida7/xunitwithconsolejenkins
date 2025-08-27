using consoleapp;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var result = Class1.Add(10, 20);
        Assert.Equal(30, result);
    }
}