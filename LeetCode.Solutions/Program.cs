Console.WriteLine("Hello World");

int[] test = new int[6];

for (int i = 0; i < 5; i++)
{
    test[i] = i;
}

int tmp = 0;
int current = 0;

for (int i = 0; i >= 0; i--)
{
    test[i + 1] = test[i];
}

test[0] = 42;

Console.WriteLine("jfdas");