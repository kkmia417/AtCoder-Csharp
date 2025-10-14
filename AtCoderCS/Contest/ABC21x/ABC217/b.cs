string[] s = new string[n];

for (int i = 0; i < n; i++)
{
    s[i] = Console.ReadLine();
}

// sの中でABC,ARC,AHC,AGCのうちないものを探す
string[] contests = { "ABC", "ARC", "AHC", "AGC" };
foreach (var contest in contests)
{
    if (!s.Contains(contest))
    {
        Console.WriteLine(contest);
        return;
    }
}