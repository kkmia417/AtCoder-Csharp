string input = Console.ReadLine();

int n = int.Parse(input);

int digit = n.ToString().Length;

int max = 4 -  digit;

//max分だけ先頭に0をつけてnを出力
string result = n.ToString().PadLeft(4, '0');
Console.WriteLine(result);