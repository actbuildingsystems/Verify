﻿using System.Threading.Tasks;
using VerifyXunit;
using Xunit;
using Xunit.Abstractions;

public class Tests :
    VerifyBase
{
    [Fact]
    public async Task Simple()
    {
        await Verify("Foo");
    }
    [Fact]
    public async Task Null()
    {
        await Verify(null);
    }

    public Tests(ITestOutputHelper output) :
        base(output)
    {
    }
}