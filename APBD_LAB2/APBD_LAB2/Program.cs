class Program
{
    static void Main()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        int max = FindMax(numbers);
        Console.WriteLine("Average: " + max);
    }

    static int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }
}