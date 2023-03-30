namespace LeetCode.Tests;

using Solutions.Solutions;

public class Test_746
{
    private MinCostClimbingStairs _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new MinCostClimbingStairs();
    }

    [Test]
    public void Test1()
    {
        int[] nums1 = {10, 15, 20};
        int[] nums2 = {1, 100, 1, 1, 1, 100, 1, 1, 100, 1};
        Assert.That(_solution.Solution(nums1), Is.EqualTo(15));
        Assert.That(_solution.Solution(nums2), Is.EqualTo(6));
    }
}