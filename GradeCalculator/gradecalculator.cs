using System;

class Program
{
    static string gradeCalculator(int grade)
    {
        if (grade >= 90)
        {
            return "You got an A.";
        }
        else if (grade >= 80)
        {
            return "You got a B.";
        }
        else if (grade >= 70)
        {
            return "You got a C.";
        }
        else if (grade >= 60)
        {
            return "You got a D."; ;
        }
        else if (grade < 60)
        {
            return "You got an F."; ;
        }
        else
        {
            return "Enter a valid grade.";
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter your grade. Should be between 0 to 100: ");
        string input = Console.ReadLine();


        if (int.TryParse(input, out int grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid Grade. Enter a grade from 0 to 100.");
            }
            else
            {
                string result = gradeCalculator(grade);
                Console.WriteLine(result);
            }
        }
    }
}