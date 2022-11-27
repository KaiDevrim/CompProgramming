public class OldestAges
{
    public static int[] TwoOldestAges(int[] ages)
    {
        int j = 0, k = 0, pos = 0;
        var items = new List<int>();
        for (var i = 0; i < ages.Length; i++)
        {
            if (k < ages[i])
            {
                pos = i;
                k = ages[i];
            }

            if (j < ages[i])
            {
                if (ages[i] == k && i != pos)
                    j = ages[i];

                else if (ages[i] < k) j = ages[i];
            }
        }

        for (var i = 0; i < ages.Length; i++)
            if (j == ages[i])
                items.Add(ages[i]);


        return new int[2] {j, k};
    }
}