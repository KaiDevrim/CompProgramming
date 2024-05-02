namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_217
{
    [SetUp]
    public void Setup()
    {
        _solution = new ContainsDuplicate();
    }

    private ContainsDuplicate _solution;

    [Test]
    public void Test1()
    {
        int[] nums1 = {1, 2, 3, 1};
        int[] nums2 = {1, 2, 3, 4};
        int[] nums3 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
        Assert.That(_solution.ContainsDuplicateNum(nums1), Is.True);
        Assert.That(_solution.ContainsDuplicateNum(nums2), Is.False);
        Assert.That(_solution.ContainsDuplicateNum(nums3), Is.True);
    }
}