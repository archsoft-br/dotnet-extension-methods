using ArchSoft.ExtensionMethods.UnitTest.Mocks;

namespace ArchSoft.ExtensionMethods.UnitTest;

public class StringExtensionTest
{
    [Fact]
    public void ToCapitalize_Null_ReturnsEmpty()
    {
        // Arrange
        string value = null;

        // Act
        var result = value.ToCapitalize();

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Theory]
    [InlineData("", "")]
    [InlineData("hello", "Hello")]
    [InlineData("wORLD", "World")]
    [InlineData("tHis is a Test", "This Is A Test")]
    public void ToCapitalize_Filled_ReturnsCapitalized(string value, string expected)
    {
        // Act
        var result = value.ToCapitalize();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ToEnum_Valid_ReturnsEnum()
    {
        // Arrange
        var value = "SP";

        // Act
        var result = value.ToEnum<EnumMock>();

        // Assert
        Assert.Equal(EnumMock.SP, result);
    }

    [Fact]
    public void ToEnum_Invalid_ReturnsNull()
    {
        // Arrange
        var value = "Invalid";

        // Act
        var result = value.ToEnum<EnumMock>();

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void ToEnum_Null_ReturnsNull()
    {
        // Arrange
        string value = null;

        // Act
        var result = value.ToEnum<EnumMock>();

        // Assert
        Assert.Null(result);
    }
}