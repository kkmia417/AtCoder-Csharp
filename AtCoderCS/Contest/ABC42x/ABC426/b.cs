using System;
using System.Linq;

string s = Console.ReadLine();

if (s.Distinct().Count() >= 2)
{
    var min = s.GroupBy(c => c).OrderBy(g => g.Count()).First().Key;
    Console.WriteLine(min);
}