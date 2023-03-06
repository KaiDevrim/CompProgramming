namespace ProjectEuler.Solutions;

public class Problem2
{
    public long EvenFibNum()
    {
        long i = 1; long j = 1; long k = 0;
        long final = 0;
        while (k <= 4000000)
        {
            k = i + j;
            if (k % 2 == 0)
            {
                final += k;
            }
            i = j;
            j = k;
        }

        return final;
    }
}