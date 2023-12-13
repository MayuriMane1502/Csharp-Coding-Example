using System;
namespace Mayuri
{
    public class Program
    {
        public static void Main()
        {
            AddNumber(10, 20); //with overloaded method
            //AddNumber(10, 20, null); //without overloading method
        }

        public static void AddNumber(int FirstNumber, int SecondNumber) //overloaded method 
        {
            AddNumber(FirstNumber, SecondNumber, null);
        }
        public static void AddNumber(int FirstNumber, int SecondNumber, int[] restOfNumbers)
        {
            int result = FirstNumber + SecondNumber;

            if (restOfNumbers != null)
            {
                foreach(int i in restOfNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum = {0}", result);
        }
    }
}