int n = int.Parse(Console.ReadLine());

if (1 <= n && n < 126)
{
    Console.WriteLine("4");
}
else if (126 <= n && n < 212)
{
    Console.WriteLine("6");
}
else
{
    Console.WriteLine("8");
}