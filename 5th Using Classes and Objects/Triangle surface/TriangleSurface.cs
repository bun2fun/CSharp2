using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
 */

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine(@"Please select the calculation you would like to do:
1. Calculate triangle's area by its base and height
2. Calculate triangle's area by the three sides
3. Calculate triangle's area by angle and two of its sides.");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            CalculateTrianglesAreaWithBaseAndHeight(); 
        }
        else if (choice == 2)
        {
            CalculateTrianglesAreaWithThreeSides();
        }
        else if (choice == 3)
        {
            CalculateTrianglesAreaWithSidesAndAngle();
        }
        else
        {
            Console.WriteLine("You have to enter 1, 2 or 3.");
        }
    }

    private static void CalculateTrianglesAreaWithSidesAndAngle()
    {
        Console.WriteLine("Please enter the angle of the triangle:");
        double angle = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the first side:");
        double side1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second side:");
        double side2 = double.Parse(Console.ReadLine());
        double area = side1 * side2 * 0.5 * (Math.Sin(angle));
        Console.WriteLine("The triangle's area is: {0}", area);
    }

    private static void CalculateTrianglesAreaWithThreeSides()
    {
        Console.WriteLine("Please enter the sides of the triangle on separate lines:");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());
        double s = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        Console.WriteLine("The triangle's area is: {0}", area);
    }

    private static void CalculateTrianglesAreaWithBaseAndHeight()
    {
        Console.WriteLine("Please enter the base of the triangle:");
        double triangleBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter its height:");
        double height = double.Parse(Console.ReadLine());
        double area = triangleBase * height / 2;
        Console.WriteLine("The triangle's area is: {0}", area);
    }
}
