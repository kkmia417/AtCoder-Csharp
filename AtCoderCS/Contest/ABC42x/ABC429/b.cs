string[] input = Console.ReadLine().Split(' ');

int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sum = 0;

for(int i = 0; i < n; i++)
{
    sum += a[i];
}

for (int i = 0; i < n; i++)
{
    if (sum - a[i] == m)
    {
        Console.WriteLine("Yes");
        return;
    }
}

Console.WriteLine("No");