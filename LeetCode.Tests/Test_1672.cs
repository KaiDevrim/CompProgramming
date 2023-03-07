namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_1672
{
    [SetUp]
    public void Setup()
    {
        _solution = new MaximumWealthSolution();
    }

    private MaximumWealthSolution _solution;

    [Test]
    public void Test1()
    {
        int[][] accounts =
        {
            new[] {1, 2, 3},
            new[] {3, 2, 1}
        };
        Assert.That(_solution.MaximumWealth(accounts), Is.EqualTo(6));
    }
}