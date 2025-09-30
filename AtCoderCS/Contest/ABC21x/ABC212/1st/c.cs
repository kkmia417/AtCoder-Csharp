using System;
using System.Linq;

string[] inputs = Console.ReadLine().Split(' ');
int n = int.Parse(inputs[0]);
int m = int.Parse(inputs[1]);

// anの入力
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

// 配列のソート
Array.Sort(a);
Array.Sort(b);


int i = 0, j = 0;
int minDiff = int.MaxValue;

// 2つの配列の要素を比較して最小の差を求める
while (i < n && j < m)
{
    minDiff = Math.Min(minDiff, Math.Abs(a[i] - b[j]));
    if (a[i] < b[j]) i++;
    else j++;
}

Console.WriteLine(minDiff);
