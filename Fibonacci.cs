using System;					
public class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter the number of objects to be generated: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The Fibonacci sequence: ");

        for (int i = 0; i < n; i++)
        {
            int result = DoFibonacci(i);
            Console.Write(result + " ");
        }

        Console.ReadLine();
    }

    static int DoFibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            int x = 0;
            int y = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = x + y;
                x = y;
                y = result;
            }

            return result;
        }
    }
}
