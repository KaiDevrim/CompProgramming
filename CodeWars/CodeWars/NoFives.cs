namespace CodeWars;

public class NoFives
{
    public static int DontGiveMeFive(int start, int end)
    {
        var i = start - 1;
        var myList = new List<int>();
        while (i < end)
        {
            i++;
            if (!i.ToString().Contains("5")) myList.Add(i);
        }

        return myList.Count;
    }
}