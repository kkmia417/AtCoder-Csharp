using System;
// 空白区切りの二つの整数の入力
// まず一行読み込む
string input = Console.ReadLine();

// 読み込んだ一行を分割する
string[] inputs = input.Split(' ');

// 分割したものをintに変換する
int a = int.Parse(inputs[0]);
int b = int.Parse(inputs[1]);

if (0 <= a && b == 0)
{
    Console.WriteLine("Gold");
}
else if (a == 0 && 0 < b)
{
    Console.WriteLine("Silver");
}
else if (0 < a && 0 < b)
{
    Console.WriteLine("Alloy");
}


