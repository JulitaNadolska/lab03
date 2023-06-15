using System;
class Program
{
    public static void Main()
    {
        int min = 1;
        int max = 20; 
        int result = GuessNumber(min, max);
        Console.WriteLine($"You guessed it! The number you are looking for is: {result}");
    }
    
    public static int GuessNumber(int min, int max)
    {
        int guess;
        
        do
        {
            guess = (min + max) / 2; 
            
            Console.WriteLine($"Is the number being searched for: {guess}?");

            int userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse < 0)
            {
                max = guess - 1; 
            }
            else if (userResponse > 0)
            {
                min = guess + 1; 
            }
            
        } while (guess != 0); 
        return guess;
    }
}