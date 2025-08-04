Console.WriteLine("Enter the lengths of the three sides of the triangle.");

Console.Write("Side 1: ");
string input1 = Console.ReadLine();
Console.Write("Side 2: ");
string input2 = Console.ReadLine();
Console.Write("Side 3: ");
string input3 = Console.ReadLine();

if (decimal.TryParse(input1, out decimal side1) &&
    decimal.TryParse(input2, out decimal side2) &&
    decimal.TryParse(input3, out decimal side3))
{
    if (side1 <= 0 || side2 <= 0 || side3 <= 0)
    {
        Console.WriteLine("Side lengths must be greater than 0.");
        return;
    }

    if (side1 + side2 > side3 &&
        side1 + side3 > side2 &&
        side2 + side3 > side1)
    {
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("This is an Equilateral triangle.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("This is an Isosceles triangle.");
        }
        else
        {
            Console.WriteLine("This is a Scalene triangle.");
        }
    }
    else
    {
        Console.WriteLine("The sides do not form a valid triangle.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter valid numbers for all sides.");
}
