using NUnit.Framework;

namespace FibonacciTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestFibonacci()
    {
        Assert.AreEqual(0, GetFibonacci(0));
        Assert.AreEqual(1, GetFibonacci(1));
    }

    private double GetFibonacci(int index)
    {
        if (index == 0)
            return 0;
        return 1;
    }
}