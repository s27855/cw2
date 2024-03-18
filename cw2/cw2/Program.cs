class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Goodbye");
        Console.WriteLine("How are you?");
        Console.WriteLine("Good i guess");
        
    }
    
    public static double CalculateAverage(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty");
        }

        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }

        return (double)sum / array.Length;
    }
    
    public static int FindMax(int[] array)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array cannot be null or empty");

        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }

}