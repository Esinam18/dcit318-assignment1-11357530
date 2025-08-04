using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a score between 0 and 100:");
        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
            }
            else
            {
                string letterGrade;

                if (grade >= 90)
                    letterGrade = "A";
                else if (grade >= 80)
                    letterGrade = "B";
                else if (grade >= 70)
                    letterGrade = "C";
                else if (grade >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";

                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
} 