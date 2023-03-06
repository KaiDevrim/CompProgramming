namespace ProjectEuler.Solutions;

public class Problem3
{
    public long LargePrimeFactor()
    {
        long max = 600851475143;
        long large = 1;
        for (long i = 3; i <= Math.Sqrt(max); i+=2)
        {
            while (max % i == 0)
            {
                max /= i;
            }
        }

        return max;
    }
}
