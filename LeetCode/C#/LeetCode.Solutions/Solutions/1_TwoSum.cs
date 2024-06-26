namespace LeetCode.Solutions.Solutions;

public class TwoSum
{
    public int[] TwoSumSolution(int[] nums, int target)
    {
        if (nums.Length == 2) return new[] {0, 1};
        for (int i = 0; i < nums.Length; i++)
        for (int j = i + 1; j < nums.Length; j++)
            if (nums[i] + nums[j] == target)
                return new[] {i, j};
        return new[] {0, 0};
    }
}