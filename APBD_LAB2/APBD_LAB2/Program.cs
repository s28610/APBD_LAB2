class Program
{
    static void Main()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Average: " + average);
    }

    static double CalculateAverage(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
}