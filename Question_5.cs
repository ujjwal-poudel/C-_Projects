/*
This program prompts the user IQ score and uses the conditional
if statements for the comparision
*/

using System;

namespace Week_4_Assignment
{
    public class Question_5
    {
        public void IqChecker()
        {
            Console.Write("Plese enter your IQ score: ");
            double iq = Convert.ToDouble(Console.ReadLine());

            if (iq > 0 && iq < 200)
            {
                if (iq > 100)
                {
                    Console.WriteLine("Wow, you got above average iq");
                }
                else if (iq == 100)
                {
                    Console.WriteLine("Cool you got average iq");
                }
                else
                {
                    Console.WriteLine("Your iq is below average, but never mind");
                }
            }
            else
            {
                Console.WriteLine("Error, You need to enter a valid iq between 0 and 200");
            }
            Console.WriteLine(new string('-', 75));
        }
    }
}