using System;
namespace Mayuri
{
    public class Program
    {
        public static void Main()
        {
            AddNumber(10, 20); //we can not declare 2 numbers only it requires all parameters value i.e. 3 numbers so we need to mark restOfNumbers = null then this error will gone

            AddNumber(10,20, new int[] { 30, 40, 50 });
        }

        public static void AddNumber(int FirstNumber, int SecondNumber, int[] restOfNumbers = null)
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