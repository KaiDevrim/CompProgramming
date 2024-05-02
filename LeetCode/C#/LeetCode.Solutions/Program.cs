int _i = 0;
int _totalCost = 0;
int[] costs = {0,1,2,2};
if (costs.Length <= 3) return costs[1];
if (costs.Length == 4)
{
    if (costs[0] <= costs[1])
    {
        _totalCost += costs[0];
    }
    else
    {
        _totalCost += costs[1];
    }

    if (costs[2] <= costs[3])
    {
        _totalCost += costs[2];
    }
    else
    {
        _totalCost += costs[3];
    }
    Console.WriteLine(_totalCost);
    return _totalCost;
}
// fix code
if (costs[0] <= costs[1])
{
    _i = 0;
    _totalCost += costs[0];
}
else if (costs[1] <= costs[0])
{
    _i = 1;
    _totalCost += costs[1];
}

while (_i <= costs.Length - 1)
{
    Console.WriteLine(_i);
    _totalCost += Math.Min(costs[_i], costs[_i + 1]);
    if (costs[_i + 1] <= costs[_i]) _i++;
    if (_i + 1 <= costs.Length) _i++;
    // Console.WriteLine(_totalCost);
}

return _totalCost;