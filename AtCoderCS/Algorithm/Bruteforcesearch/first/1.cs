using System;

string input = Console.ReadLine();

string[] inputs = input.Split(' ');

int n = int.Parse(inputs[0]);
int y = int.Parse(inputs[1]);

for (int i = 0; i <= n; ++i) // 0枚からn枚まで
{
    for (int j = 0; j <= n - i; ++j) // 残りの枚数まで
    {
        int k = n - i - j; // 1000円札の枚数は自動的に決まる

        // 金額の合計をチェックする
        if (10000 * i + 5000 * j + 1000 * k == y)
        {
            Console.WriteLine($"{i} {j} {k}");
            return; // 見つかったら終了
        }
    }
}

// ループを抜けても見つからなかった場合
Console.WriteLine("-1 -1 -1");


