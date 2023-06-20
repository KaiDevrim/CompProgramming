namespace LeetCode.Tests;

using Solutions.Solutions;

public class Test_70
{
    private ClimbStairs _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new ClimbStairs();
    }

    [Test]
    public void Test1()
    {
        Assert.That(_solution.ClimbStairsSolution(2), Is.EqualTo(2));
        Assert.That(_solution.ClimbStairsSolution(3), Is.EqualTo(3));
    }
}