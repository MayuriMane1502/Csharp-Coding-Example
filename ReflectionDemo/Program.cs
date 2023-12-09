using System;
using System.Reflection;
namespace Mayuri
{

    public class Program
    {
        public static void Main()
        {
            Assembly excutingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = excutingAssembly.GetType("Mayuri.Customer");
            object customerInstance = Activator.CreateInstance(customerType); //late binding above 3 steps are used to create a customer class
            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName"); //this method is used to getMethod

            string[] parameters = new string[2];
            parameters[0] = "Johnny";
            parameters[1] = "Depp";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

            Console.WriteLine("Full Name = {0}", fullName); 

            //early binding
            /*Customer C = new Customer();
            string fullname = C.GetFullName("Johnny", "Depp");
            Console.WriteLine("Full Name = {0}",fullname);*/
        }
    }
    public class Customer // early binding //late binding at runtime this class should be available
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}