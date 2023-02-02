/*
This program takes user input of book that student wants to buy,
and uses conditional if statements to verify, weather the purchase has
applicable discount
*/
using System;

namespace Week_4_Assignment
{
    public class Question_7
    {
        public void BookPriceCalculator()
        {
            double softcopy = 125;
            double hardcopy = 125 + (0.2 * 125);
            double discount = 0.05;
            int quantity;
            string type;
            double total;

            Console.Write("Enter the numbers of books you want to purchase: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("which copy you want to buy (Hcopy or scopy): ");
            type = Console.ReadLine()!;
            /*
            using conditional if else statement to compare the value of rate
            */

            if (quantity >= 4)
            {
                if (type == "Hcopy")
                {
                    total = (hardcopy * quantity) - discount * (hardcopy * quantity);
                    Console.WriteLine($"The total price for {quantity} hardcopy books with discount is {total:C}");
                }
                else if (type == "Scopy")
                {
                    total = (softcopy * quantity) - discount * (softcopy * quantity);
                    Console.WriteLine($"The total price for {quantity} softcopy books with discount is {total:C}");
                }
                else
                {
                    Console.WriteLine("sorry error has occured, You try again");
                }
            }
            else if (quantity < 4 && quantity > 0)
            {
                if (type == "Hcopy")
                {
                    total = (hardcopy * quantity);
                    Console.WriteLine($"The total price for {quantity} hardcopy books is {total:C}");
                }
                else if (type == "Scopy")
                {
                    total = (softcopy * quantity);
                    Console.WriteLine($"The total price for {quantity} softcopy books is {total:C}");
                }
                else
                {
                    Console.WriteLine("Sorry, unexpected error, can you repat it agin place");
                }
            }
            Console.WriteLine(new string('-', 75));
        }
    }
}