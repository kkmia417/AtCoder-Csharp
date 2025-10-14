var input = Console.ReadLine().Split();

string s = input[0];
string t = input[1];


// sとtを辞書順で比較
if (string.Compare(s, t) < 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}