using System;
class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;
        Console.Write("Input the first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Input the second number");
        num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine($"The total is: {sum}");    }
}