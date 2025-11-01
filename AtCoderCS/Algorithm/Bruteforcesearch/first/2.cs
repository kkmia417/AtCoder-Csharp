string input = Console.ReadLine();

int n = int.Parse(input);

int[] a = new int[n];

string[] inputs = Console.ReadLine().Split(' ');
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(inputs[i]);
}

int sum1 = 0;
int sum2 = 0;

Array.Sort(a);

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        sum2 += a[i];
    }
    else
    {
        sum1 += a[i];
    }
}

Console.WriteLine(sum1 - sum2);


