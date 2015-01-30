/*Write a program that enters a number n and after that enters more n numbers 
and calculates and prints their sum. Note: You may need to use a for-loop.*/
using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        Console.Write("How many numbers you want to input? ");
        double number = double.Parse(Console.ReadLine());
        double sum = 0;
        for (double i = 0; i < number; i++)
        {
            Console.Write("Enter numbers: ");
            double n = double.Parse(Console.ReadLine());
            sum += n;
        }
        Console.WriteLine("The sum of your numbers is: {0}", sum);
    }
}

