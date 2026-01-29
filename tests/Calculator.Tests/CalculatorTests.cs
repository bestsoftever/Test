namespace Calculator.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
    {
        // Arrange
        int a = 10;
        int b = -3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 10;
        int b = 3;

        // Act
        int result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Subtract_NegativeResult_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 3;
        int b = 10;

        // Act
        int result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(-7, result);
    }

    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Multiply_ByZero_ReturnsZero()
    {
        // Arrange
        int a = 5;
        int b = 0;

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_NegativeNumbers_ReturnsPositiveProduct()
    {
        // Arrange
        int a = -5;
        int b = -3;

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = 10;
        int b = 2;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Divide_WithRemainder_ReturnsDecimalQuotient()
    {
        // Arrange
        int a = 10;
        int b = 3;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(3.333333333333333, result, precision: 10);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
    }

    [Fact]
    public void Divide_NegativeNumbers_ReturnsPositiveQuotient()
    {
        // Arrange
        int a = -10;
        int b = -2;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(5.0, result);
    }
}
