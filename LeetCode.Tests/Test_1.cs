namespace LeetCode.Tests;

using Solutions.Solutions;

public class Test_1
{
    [SetUp]
    public void Setup()
    {
        _solution = new TwoSum();
    }

    private TwoSum _solution;

    [Test]
    public void Test1()
    {
        // nums = [2,7,11,15], target = 9
        // nums = [3,2,4], target = 6
        // nums = [3,3], target = 6
        int[] nums1 = {2,7,11,15};
        int[] nums2 = {3,2,4};
        int[] nums3 = {3,3};
        Assert.That(_solution.TwoSumSolution(nums1, 9), Is.EqualTo(new[] {0, 1}));
        Assert.That(_solution.TwoSumSolution(nums2, 6), Is.EqualTo(new[] {1, 2}));
        Assert.That(_solution.TwoSumSolution(nums3, 6), Is.EqualTo(new[] {0, 1}));
    }
}