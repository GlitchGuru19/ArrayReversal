//Learning about array reversal
internal class Program
{
    private static void Main(string[] args)
    {
        int length = 5;
        //Declare an array of 5 numbers
        int[] numbers = new int [length];

        //Get input from the user
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Print the original array
        Console.WriteLine("Original array:");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();

        //Reverse the array
        Array.Reverse(numbers);

        //Print the reversed array
        Console.WriteLine("Reversed array:");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Save the streak");
        }

        Console.ReadLine();
    }
}