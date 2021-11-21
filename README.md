# Autofixture Samples

## Sample Code

```csharp
// IntCalculator.cs 
using System;

namespace FixtureDemo.Domain.Services
{
    public class IntCalculator
    {
        public int Value { get; set; }
        public void Subtract(int number)
        {
            Value -= number;
        }

        public void Add(int number)
        {
            Value += number;
        }
    }
}
```

```csharp
using AutoFixture;
using FixtureDemo.Domain.Services;
using Xunit;

namespace FixtureDemo.Tests;

public class FixtureDemoTest
{
    private readonly Fixture _fixture;

    public FixtureDemoTest()
    {
        _fixture = new Fixture();
    }

    [Fact]
    public void Fixture_Test_Samples()
    {
        // Arrange
        var sut = new IntCalculator();
        var num = _fixture.Create<int>(); // Autofixture creates an int value

        // Act
        sut.Subtract(num);

        // Assert
        Assert.True(sut.Value < 0);
    }
}
```

## References

[.NET Unit Testing with AutoFixture](https://www.pluralsight.com/courses/unit-testing-autofixture-dot-net)
