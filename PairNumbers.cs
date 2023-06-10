namespace lab02;

public class PairNumbers
{
        static void Main()
        {
            Console.WriteLine("Enter the number n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pairs of numbers with sum equal to " + n + ":");

            PrintNumberPairs(n);

            Console.ReadLine();
        }

        static void PrintNumberPairs(int n)
        {
            for (int i = 1; i < n; i++)
            {
                int complement = n - i;
                Console.WriteLine("(" + i + ", " + complement + ")");
            }
        }
    }
