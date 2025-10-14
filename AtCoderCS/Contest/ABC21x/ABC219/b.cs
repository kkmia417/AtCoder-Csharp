var s1 = Console.ReadLine();
var s2 = Console.ReadLine();
var s3 = Console.ReadLine();
var t = Console.ReadLine();

string ans = "";

for(int i = 0; i < t.Length; i++)
{
    if(t[i] == '1')
    {
        ans += s1;
    }
    else if(t[i] == '2')
    {
        ans += s2;
    }
    else
    {
        ans += s3;
    }
}

Console.WriteLine(ans);