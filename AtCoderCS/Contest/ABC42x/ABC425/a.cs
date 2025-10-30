var inputs = Console.ReadLine().Split();
var n = int.Parse(inputs[0]);

int ans = 0;

for (int i = 1; i < (n + 1); i++)
{
    ans += (int)(Math.Pow(-1, i) * Math.Pow(i, 3));
}

Console.WriteLine(ans);