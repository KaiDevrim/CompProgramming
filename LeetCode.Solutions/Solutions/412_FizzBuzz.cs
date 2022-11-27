namespace LeetCode.Solutions.Solutions;

public class FizzBuzzSolution {
    public IList<string> FizzBuzz(int n)
    {
        IList<string> fizzArray = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                fizzArray.Add("FizzBuzz");
            }
    
            else if (i % 3 == 0)
            {
                fizzArray.Add("Fizz");
            }

            else if (i % 5 == 0)
            {
                fizzArray.Add("Buzz");
            }

            else
            {
                fizzArray.Add(i.ToString());
            }
        }
        return fizzArray;
    }
}