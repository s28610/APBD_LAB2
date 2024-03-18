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
        int maxi = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
            }
        }

        return maxi;
    }
}