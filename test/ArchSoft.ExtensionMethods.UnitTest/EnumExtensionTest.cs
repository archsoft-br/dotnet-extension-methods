using ArchSoft.ExtensionMethods.UnitTest.Mocks;

namespace ArchSoft.ExtensionMethods.UnitTest;

public class EnumExtensionTest
{
    [Fact]
    public void GetDescription_WithAttribute_ReturnsDescription()
    {
        // Arrange
        var value = EnumMock.SP;

        // Act
        var result = value.GetDescription();

        // Assert
        Assert.Equal("São Paulo", result);
    }
    
    [Fact]
    public void GetDescription_WithoutAttribute_ReturnsValue()
    {
        // Arrange
        var value = EnumMock.MG;

        // Act
        var result = value.GetDescription();

        // Assert
        Assert.Equal("MG", result);
    }
}