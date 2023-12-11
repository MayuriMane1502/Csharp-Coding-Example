using System;
namespace Mayuri
{
    public class Program
    {
        public static void Main()
        {
            Customer C = null;//Convert.ToString show empty string & ToString shows null reference exception
            //Customer C = new Customer();
            //string str = C.ToString();//Mayuri.Customer
            string str = Convert.ToString(C);//Mayuri.Customer
            Console.WriteLine(str); 
        }
    }
    public class Customer
    {
        public string Name { get; set; }
    }
}