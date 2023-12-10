using System;
namespace Mayuri
{
    public class Program
    {
        public static void Main()
        {
            bool Equal = Calculator<string>.AreEqual("AB","AB"); //specify the datatype after class
            //bool Equal = Calculator.AreEqual<int>(23, 23);
            if(Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }

    public class Calculator<T> // make a class generics 
    {
        //public static bool AreEqual(object Value1, object Value2) 
        public static bool AreEqual<T>(T Value1, T Value2) //generics
        {
            return Value1.Equals(Value2);
        }
    }
}