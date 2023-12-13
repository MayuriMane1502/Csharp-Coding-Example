using System;
using System.Runtime.InteropServices; // used for OptionalAttribute
namespace Mayuri
{
    public class Program
    {
        public static void Main()
        {
            AddNumber(10, 20); 
            //AddNumber(10, 20, new int[] { 30, 40, 50 });
        }

        public static void AddNumber(int FirstNumber, int SecondNumber, [Optional] int[] restOfNumbers) // all parameters are mandatory so need to give 3 or more than 3 parameters value but to avoid that we can use optional/optionalAttribute keyword
        {
            int result = FirstNumber + SecondNumber;

            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = {0}", result);
        }
    }
}