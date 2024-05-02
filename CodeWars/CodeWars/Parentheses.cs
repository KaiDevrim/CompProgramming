namespace CodeWars;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        int x = 0;
        if (input == "(" || input == ")" || !input.Contains('(') || !input.Contains(')') || input == "" || input == " " || input.StartsWith(')') || input.EndsWith('('))
        {
            return false;
        }
        foreach (char i in input)
        {
            if (i == '(')
            {
                x++;
                Console.WriteLine("Plus: " + x);
            }

            if (i == ')')
            {
                x--;
                Console.WriteLine("Minus: " + x);
            } 
        }
        return x == 0;
    }
}