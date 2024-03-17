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
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
    

}