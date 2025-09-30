using System;

string[] inputs = Console.ReadLine().Split(' ');
string s = inputs[0];
int k = int.Parse(inputs[1]);

char[] chars = s.ToCharArray();
Array.Sort(chars);
string sortedS = new string(chars);
if (k == 1)
{
    Console.WriteLine(sortedS);
    return;
}

// NextPermutationとは？
bool NextPermutation(char[] array)
{
    int n = array.Length;
    int i = n - 1;

    while (i > 0 && array[i - 1] >= array[i])
    {
        i--;
    }

    if (i <= 0)
    {
        return false;
    }

    int j = n - 1;
    while (array[j] <= array[i - 1])
    {
        j--;
    }

    char temp = array[i - 1];
    array[i - 1] = array[j];
    array[j] = temp;

    j = n - 1;
    while (i < j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        i++;
        j--;
    }

    return true;
}


chars = sortedS.ToCharArray();

for (int i = 1; i < k; i++)
{
    if (!NextPermutation(chars))
    {
        break;
    }
}
Console.WriteLine(new string(chars));