using System;

long n = long.Parse(Console.ReadLine());

int k = 0;

long ans = (long)Math.Pow(2, k);

while (ans <= n)
{
    k++;
    ans = (long)Math.Pow(2, k);
}

Console.WriteLine(k-1);