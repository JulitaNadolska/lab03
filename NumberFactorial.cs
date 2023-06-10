namespace lab02;

public class NumberFactorial
{
    static void Main()
    {
        Console.WriteLine("Enter a number x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int n = FindFactorialNumber(x);

        if (n != -1)
        {
            Console.WriteLine("The number " + x + " is a factorial of " + n);
        }
        else
        {
            Console.WriteLine("The number " + x + " is not a factorial of any number.");
        }

        Console.ReadLine();
    }

    static int FindFactorialNumber(int x)
    {
        int n = 0;
        int factorial = 1;

        while (factorial <= x)
        {
            n++;
            factorial *= n;

            if (factorial == x)
            {
                return n;
            }
        }

        return -1;
    }
}
