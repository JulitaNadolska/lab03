using System;
class Program
{
    public static void Main()
    {
        double x = 2.5; 
        int n = 10; 
        double result = EstimateExponential(x, n);
    Console.WriteLine($"e^{x} ≈ {result}");
    }
    public static double EstimateExponential(double x, int n)
    {
        double sum = 0;
        double term = 1;
        for (int i = 0; i < n; i++)
        {
            sum += term;
            term *= x / (i + 1);
        }
        return sum;
    }
}