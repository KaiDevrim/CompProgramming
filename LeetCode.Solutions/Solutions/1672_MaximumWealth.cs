namespace LeetCode.Solutions.Solutions;

public class MaximumWealthSolution {
    public int MaximumWealth(int[][] accounts)
    {
        int sum = 0;
        int total = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }

            if (sum >= total)
            {
                total = sum;
            }

            sum = 0;
        }
        return total;
    }
}