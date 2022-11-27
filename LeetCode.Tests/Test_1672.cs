using NUnit.Framework;

namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_1672
{
    private MaximumWealthSolution _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new MaximumWealthSolution();
    }

    [Test]
    public void Test1()
    {
        int[][] accounts =
        {
            new[] { 1,2,3 },
            new[] { 3,2,1 }
        };
        Assert.That(_solution.MaximumWealth(accounts), Is.EqualTo(6));
    }
    
}