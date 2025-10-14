public class Program
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());

        if (0 <= x && x < 40)
        {
            Console.WriteLine(40 - x);
        }
        else if (40 <= x && x < 70)
        {
            Console.WriteLine(70 - x);
        }
        else if (70 <= x && x < 90)
        {
            Console.WriteLine(90 - x);
        }
        else
        {
            Console.WriteLine("expert");
        }
    }
}