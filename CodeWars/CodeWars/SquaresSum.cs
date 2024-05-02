namespace CodeWars;

public class SquaresSum
{
    public static int SquareSum(int[] numbers)
    {
        List<int> squared = new List<int>();
        int i = 0, j = 0, k = 0;
        while (j+1 <= numbers.Length)
        {
            j++;
            squared.Add(numbers[i] * numbers[j]);
            Console.WriteLine(j);
            Console.WriteLine(numbers.Length);
            i++;
        }

        foreach (int num in squared)
        {
            k += num;
        }

        return k;
    }
}