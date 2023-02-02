/*This program checks the length of the message assigned by the user
and uses the method length for doing it
*/

using System;

namespace Week_4_Assignment
{
    public class Question_4
    {
        public void LengthCalculator()
        {
            string message;
            int number;

            Console.Write("Enter a short message: ");
            message = Console.ReadLine()!;

            number = message.Length;

            if (number > 150)
            {
                Console.WriteLine("Your letter count is {0}", number);
                Console.WriteLine("Thank you your message is long enough");
            }
            else
            {
                Console.WriteLine("Your words length is {0}", number);
                Console.WriteLine("Sorry your message is not lengthy. make sure to try again and reach character length of 140");
            }
            Console.WriteLine(new string('-', 75));
        }
    }
}