string[] input = Console.ReadLine().Split(' ');

int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int c = int.Parse(input[2]);

for (int i = a; i <= b; i++)
{
    if (i % c == 0)
    {
        Console.WriteLine(i);
        return;
    }
}

Console.WriteLine(-1);

