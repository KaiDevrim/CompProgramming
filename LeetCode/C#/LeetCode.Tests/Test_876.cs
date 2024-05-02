namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_876
{
    [SetUp]
    public void SetUp()
    {
        _solution = new MiddleOfLinkedListSolution();
    }

    private MiddleOfLinkedListSolution _solution;

    [Test]
    public void Test1()
    {
        int[] node = {1, 2, 3, 4, 5, 6};
        int[] solution = {4, 5, 6};
        List<int> nodeList = new(node);
        List<int> solutionList = new(solution);
        Assert.That(_solution.MiddleNode(nodeList), Is.EqualTo(solutionList));
    }
}