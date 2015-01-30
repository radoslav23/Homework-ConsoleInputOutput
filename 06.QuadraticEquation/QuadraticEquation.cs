/*Write a program that reads the coefficients a, b and c of a quadratic equation 
ax2 + bx + c = 0 and solves it (prints its real roots).*/
using System;

class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c:");
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - 4 * a * c;// Calculate discriminant

            if (discriminant < 0)
            {
                Console.WriteLine("There are no real roots!");
                return;
            }

            if (discriminant == 0)
            {
                double oneRealRoot = -(b / (2 * a));
                Console.WriteLine("The only one real root is: {0}", oneRealRoot);
            }

            else
            {
                double discriminantSqrt = Math.Sqrt(discriminant);// Calculate square root of discriminant
                double x1 = (-b - discriminantSqrt) / (2 * a);// Calculate first real root
                Console.WriteLine("x1 is: {0}", x1);
                double x2 = (-b + discriminantSqrt) / (2 * a);// Calculate second real root
                Console.WriteLine("x2 is: {0}", x2);
            }
        }
    }

