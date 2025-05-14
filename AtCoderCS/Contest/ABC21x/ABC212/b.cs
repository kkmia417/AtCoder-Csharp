using System;
using System.Linq;

string input = Console.ReadLine();
int[] digits = input.Select(c => c - '0').ToArray();

if (digits[0] == digits[1] && digits[1] == digits[2] && digits[2] == digits[3])
{
    Console.WriteLine("Weak");
    return;
}

bool isSequential = true;
for (int i = 0; i < 3; ++i)
{
    if (digits[i + 1] != (digits[i] + 1) % 10)
    {
        isSequential = false;
        break;
    }
}

Console.WriteLine(isSequential ? "Weak" : "Strong");
