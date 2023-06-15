using System;

class Program
{
    static void Main()
    {
        int n, k;
        do
        {
            Console.Write("Provide the number n (the number must NOT be less than 5):");
            n = int.Parse(Console.ReadLine());
        } while (n < 5);
        do
        {
            Console.Write("Provide the number n (the number must NOT be less than 5):  ");
            k = int.Parse(Console.ReadLine());
        } while (k < 5);
        long result = Calculate(n, k);
        Console.WriteLine($"Result: {result}");
    }
    static long Calculate(int n, int k)
    {
        long factorialN = Faktorial(n);
        long factorialK = Faktorial(k);
        long newNumber = (factorialN - factorialK) / factorialK;
        return newNumber;
    }
    static long Factorial(int x)
    {
        long expletive = 1;
        for (int i = 2; i <= x; i++)
        {
            result *= i;
        }
        return result;
    }
}