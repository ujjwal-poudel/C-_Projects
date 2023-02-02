using System;

namespace Week_4_Assignment
{
    public class program
    {
        public static void Main(string[] args)
        {
            Question_3 objA = new();
            Question_4 objB = new();
            Question_5 objC = new();
            Question_6 objD = new();
            Question_7 objE = new();

            objA.InterestCalculator();
            objB.LengthCalculator();
            objC.IqChecker();
            objD.PayRoll();
            objE.BookPriceCalculator();
        }
    }
}