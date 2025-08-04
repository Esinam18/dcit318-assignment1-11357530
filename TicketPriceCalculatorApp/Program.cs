using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age < 0)
            {
                Console.WriteLine("Invalid age. Age cannot be negative.");
                return;
            }

            decimal ticketPrice;

            // Apply discount for children (≤ 12) or seniors (≥ 65)
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7.00m;
            }
            else
            {
                ticketPrice = 10.00m;
            }

            Console.WriteLine($"Your ticket price is GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age as a number.");
        }
    }
}

