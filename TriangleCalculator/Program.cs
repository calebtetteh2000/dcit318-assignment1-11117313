using System;

class Program
{
    static string determineTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "This is an equilateral triangle.";
        }
        else if (a == b || b == c || a == c)
        {
            return "This is an isosceles triangle.";
        }
        else
        {
            return "This is a scalene triangle.";
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle: ");
        Console.Write("Side A: ");
        string inputA = Console.ReadLine();

        Console.Write("Side B: ");
        string inputB = Console.ReadLine();

        Console.Write("Side C: ");
        string inputC = Console.ReadLine();

        if (double.TryParse(inputA, out double side_a) &&
           double.TryParse(inputB, out double side_b) &&
           double.TryParse(inputC, out double side_c) &&
            side_a > 0 && side_b > 0 && side_c > 0)
        {
            string result = determineTriangleType(side_a, side_b, side_c);
            Console.WriteLine($" Result: {result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter positive numbers for the sides of the triangle.");
        }
    }
}
