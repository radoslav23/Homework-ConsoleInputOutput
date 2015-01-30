/*Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. 
Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/
using System;
using System.Runtime.ExceptionServices;

class FormattingNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            while (a < 0 || a > 500)
            {
                Console.Write("Invalid number! Try again: ");
                a = int.Parse(Console.ReadLine());
            }
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            string hex = a.ToString("X");
            var binary = Convert.ToString(a, 2).PadLeft(10, '0');
            string resultB = String.Format("{0:0.00}", b);
            string resultC  =String.Format("{0:0.000}", c);
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,10} | {3,-10}", hex, binary, resultB, resultC));
        }
    }

