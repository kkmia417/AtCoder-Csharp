string input = Console.ReadLine();

int n = int.Parse(input.Split(' ')[0]);
int p = int.Parse(input.Split(' ')[1]);

string input2 = Console.ReadLine();
string[] s = input2.Split(' ');

int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(s[i]);
}

