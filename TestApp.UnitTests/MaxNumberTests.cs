using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }


    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        List<int> oneElementList = new() { 42 };

        int result = MaxNumber.FindMax(oneElementList);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> positiveList = new() { 1, 2, 3, 4, 5, 42 };

        int result = MaxNumber.FindMax(positiveList);

        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {

        List<int> negativeList = new() { -2, -100, -1, -42 };

        int result = MaxNumber.FindMax(negativeList);

        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> negativeList = new() { -2, 100, -1, 42 };

        int result = MaxNumber.FindMax(negativeList);

        Assert.That(result, Is.EqualTo(100));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> duplicateList = new() { 100, -2, 100, -1, 42, 100 };

        int result = MaxNumber.FindMax(duplicateList);

        Assert.That(result, Is.EqualTo(100));
    }
}
