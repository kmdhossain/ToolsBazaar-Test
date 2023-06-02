using FluentAssertions;
using NSubstitute;
using ToolsBazaar.Domain.CustomerAggregate;
using Xunit;

namespace ToolsBazaar.Tests;

public class Tests
{
    [Fact]
    public void SampleTest()
    {
        var x = 10;

        x.Should().Be(10);
    }
}


