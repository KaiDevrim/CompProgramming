namespace ProjectEuler.Solutions;

public class Problem4
{
    public long LargePalindromeProduct(int k)
    {
        int product = 0;
        int j = 0;
        int result = 0;
        for (int i = 999; i > 0; i--)
        {
            for (int l = 999; l > 0; l--)
            {
                product = i * l;
                if (product == Reverse(product))
                {
                    if (product > result)
                    {
                        result = product;
                    }
                }
            }
        }

        return result;
    }
    
    int Reverse(int num)
    {
        int rev_num = 0;
        while (num > 0)
        {
            rev_num = rev_num * 10 + num % 10;
            num = num / 10;
        }
        return rev_num;
    }
}