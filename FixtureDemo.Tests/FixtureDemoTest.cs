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
        var sut = new IntCalculator();
        var num = _fixture.Create<int>();

        sut.Subtract(num);

        Assert.True(sut.Value < 0);
    }
}