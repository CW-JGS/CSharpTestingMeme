using System.Collections.Generic;
using CLib;
using Xunit;

namespace UnitTest;

public class UnitTest1
{
    [Fact]
    public void TestAdd()
    {
        var testInst = new MyMath();
        Assert.Equal(21, MyMath.Add(new List<int> {1,2,3,4,5,6}));
        
    }

    [Theory]
    [InlineData(10,5,5)]
    [InlineData(12,4,8)]
    [InlineData(20,20,0)]
    public void TestSubtract(int num1, int num2, int expected)
    {
        Assert.Equal(expected, MyMath.Subtract(num1, num2));
    }
    [Theory]
    [InlineData(2,2, 4)]
    [InlineData(2,5,10)]
    [InlineData(10,2.5,25)]
    public void testMultiply(double num1, double num2, double expected)
    {
        Assert.Equal(expected, MyMath.Multiply(num1, num2));        
    }

    [Theory]
    [InlineData(10,10,1)]
    [InlineData(6,2,3)]
    [InlineData(100,5,20)]
    public void testDivide(double num1, double num2, double expected)
    {
        Assert.Equal(expected, MyMath.Divide(num1, num2));
    }
    
    
}