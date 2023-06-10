namespace lab02;

public class Taxes
{
    static void Main()
    {
        Console.WriteLine("Enter the initial amount: ");
        double initialAmount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the annual interest rate (%): ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the number of months of savings: ");
        int numberOfMonths = Convert.ToInt32(Console.ReadLine());

        double interestRatePerMonth = interestRate / 12 / 100;
        double finalAmount = initialAmount * Math.Pow(1 + interestRatePerMonth, numberOfMonths);
        double tax = finalAmount * 0.19; 

        double finalAmountAfterTax = finalAmount - tax;

        Console.WriteLine("Final amount after " + numberOfMonths + " months: " + finalAmountAfterTax.ToString("0.00") + "zł");

        Console.ReadLine();
    }
}