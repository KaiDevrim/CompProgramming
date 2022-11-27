namespace LeetCode.Solutions.Solutions;

public class SumOf1DArraySolution {
    public int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = nums[i - 1] + nums[i];
        }
        return nums;
    }
}