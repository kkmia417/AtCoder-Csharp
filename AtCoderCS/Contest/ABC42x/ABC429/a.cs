string[] input = Console.ReadLine().Split(' ');

int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

for(int i = 1; i < n + 1; i++)
{
    if(i <= m){
    Console.WriteLine("OK");
    }
    else{
    Console.WriteLine("Too Many Requests");
    }
}