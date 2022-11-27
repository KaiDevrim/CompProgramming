namespace CodeWars;

public class IsTriangle
{
    public static bool Triangle(int a, int b, int c)
    {
        var aS = a + b > c;
        var bS = a + c > b;
        var cS = b + c > a;
        if (aS && bS && cS) return true;
        return false;
    }
}