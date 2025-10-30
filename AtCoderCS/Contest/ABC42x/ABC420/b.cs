using System;

class Program
{
    static void Main()
    {
        var inputs = Console.ReadLine().Split();
        var x = int.Parse(inputs[0]);
        var y = int.Parse(inputs[1]);

        int[] a = new int[10];
        a[0] = x;
        a[1] = y;

        for (int i = 2; i < 10; i++)
        {
            a[i] = F(a[i - 1] + a[i - 2]);
        }

        Console.WriteLine(a[9]);
    }

    static int F(int x)
    {
        char[] chars = x.ToString().ToCharArray();
        Array.Reverse(chars);
        return int.Parse(new string(chars));
    }
}