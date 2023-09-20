using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ArchSoft.ExtensionMethods.UnitTest;

public class CollectionExtensionTest
{
    [Fact]
    public void IsNullOrEmpty_Null_ReturnsTrue()
    {
        // Arrange
        List<string> collection = null;

        // Act
        var result = collection.IsNullOrEmpty();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNullOrEmpty_Empty_ReturnsTrue()
    {
        // Arrange
        var collection = new List<string>();

        // Act
        var result = collection.IsNullOrEmpty();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsNullOrEmpty_Filled_ReturnsFalse()
    {
        // Arrange
        var collection = new List<int> { 1, 2, 3 };

        // Act
        var result = collection.IsNullOrEmpty();

        // Assert
        Assert.False(result);
    }
}