int n = int.Parse(Console.ReadLine());

string[] s = new string[n];
string[] t = new string[n];

for (int i = 0; i < n; i++)
{
    // 各人の姓と名を読み込む
    var input = Console.ReadLine().Split();
    s[i] = input[0]; // 姓
    t[i] = input[1]; // 名
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (s[i] == s[j] && t[i] == t[j] && i != j)
        {
            Console.WriteLine("Yes");
            return;
        }
    }
}

Console.WriteLine("No");    