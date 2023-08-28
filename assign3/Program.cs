using System;

static class assign3
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("The array cannot be empty.");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            double average = assign3.CalculateAverage(numbers);
            Console.WriteLine($"Average: {average}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
