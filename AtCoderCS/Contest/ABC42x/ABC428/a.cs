using System.Runtime.InteropServices.Marshalling;

string[] input = Console.ReadLine().Split(' ');

int s = int.Parse(input[0]);
int a = int.Parse(input[1]);
int b = int.Parse(input[2]);
int x = int.Parse(input[3]);

int ans = 0;

while (x > 0)
{
    for (int i = 0; i < a; i++)
    {
        x -= 1;
        ans += s;
        
        if (x <= 0) break;
    }
    
    x -= b;
}

Console.WriteLine(ans);