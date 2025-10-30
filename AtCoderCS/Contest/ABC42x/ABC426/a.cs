var input = Console.ReadLine().Split();

string x = input[0];
string y = input[1];

string[] server = { "Ocelot", "Serval", "Lynx" };

if (Array.IndexOf(server, x) > Array.IndexOf(server, y))
{
    Console.WriteLine("Yes");
}
else if (Array.IndexOf(server, x) < Array.IndexOf(server, y))
{
    Console.WriteLine("No");
}
else if (x == y)
{
    Console.WriteLine("Yes");
}