/*Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/
using System;
using System.Runtime.InteropServices;

class NumberCompare
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());           
            Console.WriteLine(Math.Max(a, b));
        }
    }

