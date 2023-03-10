namespace LeetCode.Solutions.Solutions;

public class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s == t)
        {
            return true;
        }

        if (s.Length != t.Length)
        {
            return false;
        }

        char[] sortedS = s.ToCharArray();
        char[] sortedT = t.ToCharArray();
        Array.Sort(sortedS);
        Array.Sort(sortedT);

        if (sortedS.SequenceEqual(sortedT))
        {
            return true;
        }
        return false;
    }
}