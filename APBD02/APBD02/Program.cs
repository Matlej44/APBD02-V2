namespace APBD02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Console.WriteLine("Feature-conflict");
        
        Console.WriteLine(Math.PI);
        
        Console.WriteLine("Hello, World!".GetHashCode());
        
        Console.WriteLine(DateTime.Now);
        
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine(CalculateAvarage(numbers));
        
        Console.WriteLine(CalculateMax(numbers));
    }
    public static double CalculateAvarage(int[] numbers)
    {
        double avg = numbers.Sum() / numbers.Length;
        return avg;
    }
    public static int CalculateMax(int[] numbers)
    {
        int max = numbers.Max();
        return max;
    }

    public static int CalculateMin(int[] numbers)
    {
        int min = numbers.Min();
        return min;
    }
}