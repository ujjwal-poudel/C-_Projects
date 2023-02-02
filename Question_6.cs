/*
This program will takes user input about their hourly pay rate
and use conditional if statements to identry which tax is applied
for greater and lesser gross pay
*/

using System;

namespace Week_4_Assignment
{
    public class Question_6
    {
        public void PayRoll()
        {
            double pay, hour, grossPay;
            Console.Write("Enter your hourly pay rate: ");
            pay = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of hours you worked: ");
            hour = Convert.ToDouble(Console.ReadLine());

            grossPay = pay * hour;
            
            /*
            Using if conditional statement to check whether the user's 
            gross pay is higher than 300 or not
            */

            if (grossPay <= 300)
            {
                Console.WriteLine($"Your gross pay is {grossPay:C} without including tax");
                double withholdingTax = 0.1 * grossPay;
                double finalPay = grossPay - withholdingTax;
                Console.WriteLine("");
                Console.WriteLine($"Your withholding tax is {withholdingTax:C}");
                Console.WriteLine($"Your pay after reducing tax is {finalPay:C} as 10% tax defined");
            }
            else if (grossPay > 300)
            {
                Console.WriteLine($"Your gross pay is {grossPay:C} without including tax");
                double withholdingTax = 0.12 * grossPay;
                double finalPay = grossPay - withholdingTax;
                Console.WriteLine("");
                Console.WriteLine($"Your withholding tax is {withholdingTax:C} as 12% tax rate defined");
                Console.WriteLine($"Your pay after reducing tax is {finalPay:C}");
            }
            else
            {
                Console.WriteLine("sorry, Please enter a valid input either float or integer");
            }
            Console.WriteLine(new string('-', 75));
        }
    }
}