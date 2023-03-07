namespace LeetCode.Solutions.Solutions;

public class SingleNumber
{
    public int IsSingleNumber(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
        int num = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            num = num ^ nums[i];
        }

        return num;
    }
}