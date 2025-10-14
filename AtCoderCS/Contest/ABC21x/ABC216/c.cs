long n = long.Parse(Console.ReadLine());

// 操作の履歴を記録する
var result = new System.Text.StringBuilder();

while (n > 0)
{
    if (n % 2 == 0)
    {
        result.Append("B");
        n /= 2;
    }
    else
    {
        result.Append("A");
        n -= 1;
    }
}

// 操作の履歴を逆順にして出力
var output = result.ToString().ToCharArray();
Array.Reverse(output);
Console.WriteLine(new string(output));