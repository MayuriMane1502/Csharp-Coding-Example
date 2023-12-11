using System;
namespace Mayuri
{
    public class Program
    {
        public static void Main()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString()); 

            Customer C1 =new Customer();
            C1.FirstName = "Johnny";
            C1.LastName = "Depp";

            //Console.WriteLine(C1.ToString()); // default implementation include the Class name with namespace- Mayuri.Customer
            Console.WriteLine(Convert.ToString(C1));
           
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //override ToString() method
        public override string ToString()
        {
            //return base.ToString();// will show Mayuri.Customer
            return this.LastName + "," + this.FirstName;
        }
    }
}