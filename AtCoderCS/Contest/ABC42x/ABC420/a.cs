int n = int.Parse(Console.ReadLine());

string[] resi = new string[n];
for (int i = 0; i < n; i++)
{
    resi[i] = Console.ReadLine();
}

string[] input = Console.ReadLine().Split(' ');

int x = int.Parse(input[0]);
string y = input[1];

if (resi[x - 1] == y)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

