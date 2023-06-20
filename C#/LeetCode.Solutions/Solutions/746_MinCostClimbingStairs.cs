namespace LeetCode.Solutions.Solutions;

public class MinCostClimbingStairsSolution
{
    private int _i;
    private int _totalCost;
    public int MinCostClimbingStairs(int[] cost)
    {
        if (cost.Length <= 3) return cost[1];

        if (cost[0] > cost[1])
        {
            _i = 0;
            _totalCost += cost[0];
        }
        else if (cost[1] <= cost[0])
        {
            _i = 1;
            _totalCost += cost[1];
        }

        while (_i <= cost.Length - 2)
        {
            _totalCost += Math.Min(cost[_i], cost[_i + 1]);
            if (cost[_i + 1] <= cost[_i]) _i++;
            if (_i + 1 <= cost.Length) _i++;
        }

        return _totalCost;
    }
}