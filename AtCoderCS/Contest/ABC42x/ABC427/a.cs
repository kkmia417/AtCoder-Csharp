string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    if (i == input.Length / 2)
    {
        input = input.Remove(i, 1);
    }
}

Console.WriteLine(input);