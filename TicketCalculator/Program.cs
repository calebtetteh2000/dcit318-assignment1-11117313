using System;

class Program
{
    static double ticketCalculator(int age)
    {
        if (age <= 12 || age >= 65)
        {
            return 7.0;
        }
        else
        {
            return 10;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            double ticketPrice = ticketCalculator(age);
            Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
