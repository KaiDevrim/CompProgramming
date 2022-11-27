namespace CodeWars;

public class SplitString
{
    public static string[] Solution(string str)
    {
        var insert = string.Empty;
        var j = 0;
        var k = 0;
        var splits = new List<string>();
        for (var i = 1; i < str.Length; i += 2)
        {
            insert = string.Concat(str[i - 1], str[i]);
            splits.Insert(k, insert);

            j++;
            if (j == 1)
            {
                j = 0;
                k++;
            }
        }

        if (str.Length % 2 != 0)
        {
            splits.Insert(splits.Count, str.Last().ToString() + '_');
        }

        foreach (var f in splits.ToArray()) Console.WriteLine(f);
        return splits.ToArray();
    }
}