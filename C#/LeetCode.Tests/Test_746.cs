namespace LeetCode.Tests;

using Solutions.Solutions;

public class Test_746
{
    private readonly MinCostClimbingStairsSolution _solution = new();

    [Test]
    public void Test1()
    {
        int[] nums1 = {10, 15, 20};
        Assert.That(_solution.MinCostClimbingStairs(nums1), Is.EqualTo(15));
    }

    [Test]
    public void Test2()
    {
        int[] nums2 = {1, 100, 1, 1, 1, 100, 1, 1, 100, 1};
        Assert.That(_solution.MinCostClimbingStairs(nums2), Is.EqualTo(6));
    }

    [Test]
    public void Test3()
    {
        int[] nums3 = {0, 1, 2, 2};
        Assert.That(_solution.MinCostClimbingStairs(nums3), Is.EqualTo(2));
    }

    [Test]
    public void Test4()
    {
        int[] nums4 = {0, 1, 1, 0};
        Assert.That(_solution.MinCostClimbingStairs(nums4), Is.EqualTo(1));
    }
}