namespace CodeWars;

public class Program
{
    public static void Main(string[] args)
    {
        RunSquareSum();
    }
    // Working
    public static void RunTwoOldestAges()
    {
        int[] myArray = {102, 102, 102, 101, 103};
        var result = OldestAges.TwoOldestAges(myArray);
        foreach (var item in result) Console.WriteLine(item.ToString());
    }
    // Not Working
    public static void RunPrimeNumbers()
    {
        int[] myArray =
        {
            1, -1, 0, 556434, 28343890, 984238, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67,
            71, 73, 79, 83, 89, 97
        };
        foreach (var item in myArray) PrimeNumbers.IsPrime(item);
    }
    // Working
    public static void RunNoFives()
    {
        int[] myArray = {4, 17};
        Console.WriteLine(NoFives.DontGiveMeFive(myArray[0], myArray[1]));
    }
    // Not Working
    public static void RunTriangle()
    {
        var a = 5;
        var b = 7;
        var c = 10;
        IsTriangle.Triangle(a, b, c);
    }
    // Not Working
    public static void RunLastDigit()
    {
        var a = 9;
        var b = 7;
        LastDigit.GetLastDigit(a, b);
    }
    // Working
    public static void RunGimme()
    {
        double[] myArray = {5, 11, 7};
        GetMiddleIndex.Gimme(myArray);
    }
    // Working
    public static void RunIp()
    {
        var IP = "251.113.7.";
        Console.WriteLine(ValidIP.is_valid_IP(IP));
    }
    // Not Working
    public static void RunCamelCase()
    {
        var str = "the-stealth-warrior";
        ToCamelCase.CamelCase(str);
    }
    // Not Working
    public static void RunAnagram()
    {
        Anagram.IsAnagram("foefet", "toffee");
    }
    // Working
    public static void RunSplits()
    {
        var a = "abcd";
        SplitString.Solution(a);
    }

    public static void RunParenthesis()
    {
        Console.WriteLine(Parentheses.ValidParentheses(")"));
    }

    public static void RunSquareSum()
    {
        int[] numbers = {1, 2, 2};
        Console.WriteLine(SquaresSum.SquareSum(numbers));
    }
}