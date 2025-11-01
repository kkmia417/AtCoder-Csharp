long n = long.Parse(Console.ReadLine());


if (n == 0)
{
    Console.WriteLine(1);
    return;
}

long c = 1;
long p = Sum(c);

for (long i = 1; i <= n; i++)
{
    c = p;
    if (i == n)
    {
        Console.WriteLine(c);
        return;
    }
    p += Sum(c);
}

static long Sum(long x)
{
    long s = 0;
    while (x > 0)
    {
        s += x % 10;
        x /= 10;
    }
    return s;
}