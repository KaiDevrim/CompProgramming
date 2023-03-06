namespace ProjectEuler.Solutions;

public class Problem1
{
    public int MultiplesOf3Or5()
    {
        int j = 0;
        for (int i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                j += i;
            }
        }

        return j;
    }
}