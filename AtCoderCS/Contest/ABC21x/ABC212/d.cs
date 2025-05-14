using System;
using System.Collections.Generic;

int Q = int.Parse(Console.ReadLine());
var result = new List<long>();
var bag = new SortedSet<(long value, int id)>();
long offset = 0;
int idCounter = 0;

for (int i = 0; i < Q; ++i)
{
    var parts = Console.ReadLine().Split();
    int type = int.Parse(parts[0]);

    if (type == 1)
    {
        long x = long.Parse(parts[1]);
        bag.Add((x - offset, idCounter++));
    }
    else if (type == 2)
    {
        long x = long.Parse(parts[1]);
        offset += x;
    }
    else if (type == 3)
    {
        var min = bag.Min;
        bag.Remove(min);
        result.Add(min.value + offset);
    }
}

foreach (var x in result)
{
    Console.WriteLine(x);
}
