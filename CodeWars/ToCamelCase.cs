namespace CodeWars;

using System.Text;

public class ToCamelCase
{
    public static string CamelCase(string str)
    {
        var x = 0;
        var y = 0;
        var isUp = char.IsUpper(str[0]);
        var sb = new StringBuilder(str.Length);
        foreach (var i in str)
        {
            y++;
            if (i != '-')
            {
                if (x == 1)
                {
                    sb.Append(i.ToString().ToUpper());
                    x = 0;
                }

                if (y == 1)
                    if (isUp)
                        sb.Append(i.ToString().ToUpper());

                if (y != 0 && x != 1) sb.Append(i.ToString());
            }

            if (i == '-') x++;
        }

        str = sb.ToString();
        Console.WriteLine(str);
        return str;
    }
}