namespace lab02;

public class ThreeRandomNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a [N] number with at least 3 digits: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 100)
        {
            Console.WriteLine("Individual digits of the number:");

            while (number > 0)
            {
                int digit = number % 10;
                
                Console.WriteLine(digit);

                number /= 10;
            }
        }
        else
        {
            Console.WriteLine("The number does not have at least 3 digits.");
        }

        Console.ReadLine();
    }
}
