using Xunit;

public class CalculatorTests
{
    [Theory]
    [InlineData(2, 3, '+', 5)]
    [InlineData(5, 3, '-', 2)]
    [InlineData(4, 2, '*', 8)]
    [InlineData(8, 2, '/', 4)]
    public void TryCompute_WithValidOperator_ReturnsExpectedResult(
        double left,
        double right,
        char op,
        double expected)
    {
        bool ok = Calculator.TryCompute(left, right, op, out double result);

        Assert.True(ok);
        Assert.Equal(expected, result, precision: 10);
    }

    [Fact]
    public void TryCompute_WithDivisionByZero_ReturnsNaN()
    {
        bool ok = Calculator.TryCompute(10, 0, '/', out double result);

        Assert.True(ok);
        Assert.True(double.IsNaN(result));
    }

    [Fact]
    public void TryCompute_WithInvalidOperator_ReturnsFalse()
    {
        bool ok = Calculator.TryCompute(1, 2, '%', out double result);

        Assert.False(ok);
        Assert.Equal(0, result);
    }
}
