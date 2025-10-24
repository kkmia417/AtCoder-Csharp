string input = Console.ReadLine();

int a = int.Parse(input.Split(' ')[0]);
int b = int.Parse(input.Split(' ')[1]);


int m = a - b;
int mag = (int)Math.Pow(32,m);

Console.WriteLine(mag);