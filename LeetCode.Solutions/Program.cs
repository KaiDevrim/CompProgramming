Console.WriteLine("Hello World");
string s = "car";
string t = "cra";
Dictionary<char, int> letters = new Dictionary<char, int>
{
    {'A', 1},
    {'B', 2},
    {'C', 3},
    {'D', 4},
    {'E', 5},
    {'F', 6},
    {'G', 7},
    {'H', 8},
    {'I', 9},
    {'J', 10},
    {'K', 11},
    {'L', 12},
    {'M', 13},
    {'N', 14},
    {'O', 15},
    {'P', 16},
    {'Q', 17},
    {'R', 18},
    {'S', 19},
    {'T', 20},
    {'U', 21},
    {'V', 22},
    {'W', 23},
    {'X', 24},
    {'Y', 25},
    {'Z', 26}
};

if (s == t) Console.WriteLine("true");

char[] charS = s.ToUpper().ToCharArray();
char[] charT = t.ToUpper().ToCharArray();

for (int i = 0; i < s.Length - 1; i++)
for (int j = 0; j < s.Length - i - 1; j++)
    if (letters[charS[j]] > letters[charS[j + 1]])
    {
        char tempVar = charS[j];
        charS[j] = charS[j + 1];
        charS[j + 1] = tempVar;
    }

for (int i = 0; i < t.Length - 1; i++)
for (int j = 0; j < t.Length - i - 1; j++)
    if (letters[charT[j]] > letters[charT[j + 1]])
    {
        char tempVar = charT[j];
        charT[j] = charT[j + 1];
        charT[j + 1] = tempVar;
    }

if (charS.SequenceEqual(charT)) Console.WriteLine("true");

if (!charS.SequenceEqual(charT)) Console.WriteLine("false");