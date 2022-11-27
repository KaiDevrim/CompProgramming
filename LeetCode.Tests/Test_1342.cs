using NUnit.Framework;

namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_1342
{
    private ReduceToZeroSolution _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new ReduceToZeroSolution();
    }

    [Test]
    public void Test1()
    {
        Assert.That(_solution.NumberOfSteps(14), Is.EqualTo(6));
    }
}