using System;
using System.Collections.Generic;
using System.Linq;

var input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int k = int.Parse(input[1]);

string s = Console.ReadLine();

var cnt = new Dictionary<string, int>();

for (int i = 0; i <= n - k; i++)
{
    string sub = s.Substring(i, k);
    if (cnt.TryGetValue(sub, out var c)) cnt[sub] = c + 1;
    else cnt[sub] = 1;
}

int x = cnt.Values.Max();
var ans = cnt.Where(p => p.Value == x)
             .Select(p => p.Key)
             .OrderBy(t => t)
             .ToArray();

Console.WriteLine(x);
Console.WriteLine(string.Join(" ", ans));