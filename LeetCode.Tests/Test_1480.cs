namespace LeetCode.Tests;

using Solutions.Solutions;
[TestFixture]
public class Test_1480
{
    private SumOf1DArraySolution _solution;
    [SetUp]
    public void Setup()
    {
        _solution = new SumOf1DArraySolution();
    }

    [Test]
    public void Test1()
    {
        Assert.That(_solution.RunningSum(new int[] {1,2,3,4}), Is.EqualTo(new int[] {1,3,6,10}));
    }
}