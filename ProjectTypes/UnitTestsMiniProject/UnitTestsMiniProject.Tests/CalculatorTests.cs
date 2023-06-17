using UnitTestsMiniProjectLibrary;

namespace UnitTestsMiniProject.Tests;

public class CalculatorTests
{
    // TODO: write calculator tests for all methods and edge cases!
    
    [Fact]
    public void AddShouldWorkWithDoubles()
    {
        // Arrange
        Calculator calculator = new Calculator();
        double expected = 6.66;

        // Act
        double actual = calculator.Add(6, 0.66);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 4, 6)]
    public void AddShouldWorkWithDoublesTheory(double x, double y, double expected)
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        double actual = calculator.Add(x, y);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SubtractShouldWorkWithDoubles()
    {
        // Arrange
        Calculator calculator = new Calculator();
        double expected = 5.34;

        // Act
        double actual = calculator.Subtract(6, 0.66);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MultiplyShouldWorkWithDoubles()
    {
        // Arrange
        Calculator calculator = new Calculator();
        double expected = 3.96;

        // Act
        double actual = calculator.Multiply(6, 0.66);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void DivideShouldWorkWithDoubles()
    {
        // Arrange
        Calculator calculator = new Calculator();
        double expected = 10;

        // Act
        double actual = calculator.Divide(6, 0.6);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(6, 0, 0)]
    public void DivideShouldReturnZeroWhenDividingByZero(double x, double y, double expected)
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        double actual = calculator.Divide(x, y);

        // Assert
        Assert.Equal(expected, actual);
    }
}