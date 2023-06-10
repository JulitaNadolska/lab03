using System;					
public class Potentiation
{
    public static void Main()
    {
        Console.WriteLine("Enter the basis: ");
        int basis = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        int result = DoPotentiation(basis, exponent);
        Console.WriteLine("Result: " + result);

        Console.ReadLine();
    }

    static int DoPotentiation(int basis, int exponent)
    {
        int result = 1;

        for (int i = 0; i < exponent; i++)
        {
            result *= basis;
        }

        return result;
    }
}
