namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_1480
{
    [SetUp]
    public void Setup()
    {
        _solution = new SumOf1DArraySolution();
    }

    private SumOf1DArraySolution _solution;

    [Test]
    public void Test1()
    {
        Assert.That(_solution.RunningSum(new[] {1, 2, 3, 4}), Is.EqualTo(new[] {1, 3, 6, 10}));
    }
}