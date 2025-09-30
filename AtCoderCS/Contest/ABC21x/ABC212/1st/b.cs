using System;
using System.Linq;

// 空白区切りじゃない4つの整数の入力 Linq使う

string inputs = Console.ReadLine();

// 4つの整数に変える
int[] input = inputs.Select(c => c - '0').ToArray();

// int[] input = inputs - '0';

// for (int i = 0; i < 3; ++i)
// {
//     if (input[i] % 10 == input[i + 1] % 10 || input[i] == input[i+1])
//     {
//         Console.WriteLine("Weak");
//     }
//     else
//     {
//         Console.WriteLine("Strong");
//     }
// }

// 二つの条件を用意して書くほうがきれい

bool allSame = (input[0] == input[1] && input[1] == input[2] && input[2] == input[3]);
bool isSequential = true;

for (int i = 0; i < 3; ++i)
{
    if ((input[i] + 1 )% 10 != input[i + 1])
    {
        isSequential = false;
        break;
    }
}

if (allSame || isSequential)
{
    Console.WriteLine("Weak");
}
else
{
    Console.WriteLine("Strong");
}