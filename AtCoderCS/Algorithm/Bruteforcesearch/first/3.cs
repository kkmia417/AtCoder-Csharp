string input = Console.ReadLine();

int n = int.Parse(input);

int[] d = new int[n];
for (int i = 0; i < n; ++i)
{
    string inpt = Console.ReadLine();
    d[i] = int.Parse(inpt);
}

d = d.Distinct().ToArray();

Array.Sort(d);
Array.Reverse(d);

int count = 1;
bool flag = false;

while (!flag)
{
    flag = true;
    for (int i = 0; i < d.Length - 1; ++i)
    {
        if (d[i] - d[i + 1] > 0)
        {
            count++;
        }
        else
        {
            count++;
            flag = false;
        }
    }
}

Console.WriteLine(count);







