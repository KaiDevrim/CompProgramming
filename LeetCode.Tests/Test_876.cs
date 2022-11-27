using NUnit.Framework;

namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_876
{
    private MiddleOfLinkedListSolution _solution;

    [SetUp]
    public void SetUp()
    {
        _solution = new MiddleOfLinkedListSolution();
    }

    [Test]
    public void Test1()
    {
        int[] node = {1,2,3,4,5,6};
        int[] solution = {4,5,6};
        List<int> nodeList = new List<int>(node);
        List<int> solutionList = new List<int>(solution);
        Assert.That(_solution.MiddleNode(nodeList), Is.EqualTo(solutionList));
    }
}