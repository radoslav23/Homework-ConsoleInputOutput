/*Write a program that reads a number n and prints on the console 
the first n members of the Fibonacci sequence 
(at a single line, separated by comma and space - ,) 
: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.*/
using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("How many Fibonacci numbers you want to print?");
        decimal n = decimal.Parse(Console.ReadLine());
        decimal firstNumber = 0;    // Set first Fibonacci number
        decimal secondNumber = 1;   // Set second Fibonacci number
        decimal sum;

        for (int i = 0; i < n; i++)
        {
            Console.Write(firstNumber + " ");
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
        }
    }
}

