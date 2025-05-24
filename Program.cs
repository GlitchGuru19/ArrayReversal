//Learning about array reversal
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[]
        {
            0,1,2,3,4,5
        };

        Array.Reverse(numbers);

        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }

        Console.ReadLine();
    }
}