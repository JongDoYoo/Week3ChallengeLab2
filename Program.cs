using System.Diagnostics.CodeAnalysis;

namespace Week3ChallengeLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any random letter and number : ");
            string input = Console.ReadLine();

            double sum = 0;

            for (int i = 0; i < input.Length; i++) 
            {
                double number = Char.GetNumericValue(input, i);
                if (number != -1)
                {
                    sum = sum + number;
                }
             
            }
            Console.WriteLine("The total of the number digit is: " + sum);
        }                
    }
}





//2.Sum digits in string

////Given a string, write a method which returns sum of all digits in that string. Assume that string contains only single digits.

////Expected input and output

////SumDigitsInString("1q2w3e") → 6 SumDigitsInString("L0r3m.1p5um") → 9

////SumDigitsInString("") → 0