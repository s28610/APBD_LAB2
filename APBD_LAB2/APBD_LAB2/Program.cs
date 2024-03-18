class Program
{
    static void Main()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        int max = FindMax(numbers);
        Console.WriteLine("Average: " + max);
    }

    static int FindMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }
}