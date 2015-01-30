/*Write a program that reads two positive integer numbers 
and prints how many numbers p exist between them 
such that the reminder of the division by 5 is 0.*/
using System;

class NumbersDividableByGivenNumber
{
    static void Main()
    {
        
        Console.WriteLine("Enter your first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers between {0} and {1} " +
                          "divided by five without reminder are:", firstNumber, secondNumber);

        int count = 0;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
                count++;
            }
        }
        Console.WriteLine("Total numbers: " + count);
    }
}

