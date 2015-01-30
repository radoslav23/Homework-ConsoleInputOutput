/*Write a program that reads the radius r of a circle and prints its perimeter 
and area formatted with 2 digits after the decimal point.*/
using System;

class CirclePerimeterAndArea
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2*Math.PI*radius;
            Console.WriteLine("{0:F2}", perimeter);
            double area = Math.PI*(radius*radius);
            Console.WriteLine("{0:F2}", area);
        }
    }

