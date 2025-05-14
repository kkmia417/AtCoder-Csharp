using System;

var input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);


if(0 < a && b == 0)
{
    Console.WriteLine("Gold");
}
else if(a == 0 && 0 < b)
{
    Console.WriteLine("Silver");
}
else if(0 < a && 0 < b)
{
    Console.WriteLine("Alloy");
}

