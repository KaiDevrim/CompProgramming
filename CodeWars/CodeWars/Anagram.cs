namespace CodeWars;

public class Anagram
{
    public static bool IsAnagram(string test, string original)
    {
        Console.WriteLine(original == test.Reverse().ToString());
        return original.ToLower() == new string(test.ToLower().ToCharArray().Reverse().ToArray());
    }
}