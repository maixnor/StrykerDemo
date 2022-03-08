using System;
using Source;
using Xunit;

namespace Tests;

public class CalculatorTests
{
    [InlineData(4, 0, 4)]
    [InlineData(4, 3, 7)]
    [Theory]
    public void Add(int a, int b, int result)
    {
        Assert.Equal(Calculator.Add(a, b), result);
    }
    
    [InlineData(3, 0, 3)]
    [InlineData(3, 5, -2)]
    [Theory]
    public void Sub(int a, int b, int result)
    {
        Assert.Equal(Calculator.Sub(a, b), result);
    }
    
    [InlineData(1, 0, 0)]
    [InlineData(-2, 4, -8)]
    [Theory]
    public void Mul(int a, int b, int result)
    {
        Assert.Equal(Calculator.Mul(a, b), result);
    }
    
    [InlineData(4, 0, 0, true)]
    [Theory]
    public void Div(int a, int b, int result, bool throws)
    {
        if (throws)
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Div(a, b));
        }
        else
        {
            Assert.Equal(Calculator.Div(a, b), result);
        }
    }
}