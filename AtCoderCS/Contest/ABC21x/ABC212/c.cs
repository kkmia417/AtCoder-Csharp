using System;
using System.Linq;

var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = nm[0];
int M = nm[1];

var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

var B = Console.ReadLine().Split().Select(int.Parse).ToArray();

while (i < N && j < M)
{
    int diff = Math.Abs(A[i] - B[j]);
    minDiff = Math.Min(minDiff, diff);

    if (A[i] < B[j])
    {   i++;
    else
        j++;
    }
}
