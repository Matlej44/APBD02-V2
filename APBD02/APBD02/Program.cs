namespace APBD02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Console.WriteLine("First commit");
        
        Console.WriteLine(Math.PI);
        
        Console.WriteLine("Hello, World!".GetHashCode());
        
        Console.WriteLine(DateTime.Now);
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
}