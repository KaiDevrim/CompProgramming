namespace LeetCode.Tests;

using Solutions.Solutions;

[TestFixture]
public class Test_136
{
    [SetUp]
    public void Setup()
    {
        _solution = new SingleNumber();
    }

    private SingleNumber _solution;

    [Test]
    public void Test1()
    {
        int[] nums1 = {2, 2, 1};
        int[] nums2 = {4, 1, 2, 1, 2};
        int[] nums3 = {1};
        Assert.AreEqual(_solution.IsSingleNumber(nums1), 1);
        Assert.AreEqual(_solution.IsSingleNumber(nums2), 4);
        Assert.AreEqual(_solution.IsSingleNumber(nums3), 1);
    }
}