using System;
namespace Mayuri
{
    public class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Johnny";
            C1.LastName = "Depp";

            Customer C2 = new Customer();
            C1.FirstName = "Johnny";
            C1.LastName = "Depp";

            //Customer C2 = C1;

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.East;
            Console.WriteLine("Direction");

            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));
            Console.WriteLine("Name");
            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }
    }
    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(!(obj is Customer))
            {
                return false;
            }

            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}