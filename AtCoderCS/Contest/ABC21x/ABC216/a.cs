var inputs = Console.ReadLine().Split('.');
var x = int.Parse(inputs[0]);
var y = int.Parse(inputs[1]);

if (y >= 0 && y <= 2)
{
    Console.WriteLine(x + "-");
}
else if (y >= 3 && y <= 6)
{
    Console.WriteLine(x);
}
else if (y >= 7 && y <= 9)
{
    Console.WriteLine(x + "+");
}