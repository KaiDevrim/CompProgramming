namespace CodeWars;

using System.Numerics;

public class LastDigit
{
    public static int GetLastDigit(BigInteger n1, BigInteger n2)
    {
        if (n1 == 0 && n2 == 0) return 0;
        var pow = BigInteger.Pow(n1, (int) n2);
        var finalS = pow.ToString().Last();
        return int.Parse(finalS.ToString());
    }
}