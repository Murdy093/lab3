using System;

class Program
{
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = FindGCD(num1, num2);

        Console.WriteLine($"НСД ({num1}, {num2}) = {gcd}");
        Console.WriteLine("\nPress any key to complete...");
        Console.ReadKey();
    }   

}
