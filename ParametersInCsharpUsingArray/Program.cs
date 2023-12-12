using System;
namespace Mayuri
{
    public class Program
    {
        public static void Main()
        {
            //AddNumbers(10, 20); //sum = 30
            AddNumbers(10, 20, 30, 40, 50); //sum= 150 (30,40,50 pass as object to parameter)
            AddNumbers(10, 20, new object[] { 30, 40, 50 }); //alternate method same o/p
        }

        public static void AddNumbers(int FirstNumber, int SecondNumber, params object[] restOfNumbers)
        {
            int result = FirstNumber + SecondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
                Console.WriteLine("Sum= {0}", result);
            }
        }
    }
}