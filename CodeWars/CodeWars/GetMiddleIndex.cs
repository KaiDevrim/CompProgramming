namespace CodeWars;

public class GetMiddleIndex
{
    public static int Gimme(double[] inputArray)
    {
        var mid = inputArray.OrderByDescending(x => x).ElementAt(1);
        return Array.IndexOf(inputArray, mid);
    }
}