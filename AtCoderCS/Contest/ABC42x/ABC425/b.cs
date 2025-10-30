var inputs = Console.ReadLine().Split();
var n = int.Parse(inputs[0]);

var a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(inputs[i + 1]);
}

for (int i = 0; i < n; i++)
{
    if (a[i] < 0)
    {
        a[i] = -a[i];
    }
}
