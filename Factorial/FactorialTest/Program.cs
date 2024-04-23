using System;
using FactorialLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter No: ");
        long n = Convert.ToInt32(Console.ReadLine());
        long result = Factorial.Calculate(n);
        Console.WriteLine("Factorial of " + n + " is: " + result);
    }
}
