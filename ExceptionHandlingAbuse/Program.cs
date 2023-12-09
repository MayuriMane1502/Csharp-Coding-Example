using System;

public class Program
{
    public static void Main()
    {
        try
        {

            Console.WriteLine("Please enter Numerator");
            int Numerator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Denominator");
            int Denominator = Convert.ToInt32(Console.ReadLine());

            int Result = Numerator / Denominator;
            Console.WriteLine("Result - {0}", Result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter the Number");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Only numbers between range {0} to {1} are allowed", Int32.MinValue, Int32.MaxValue);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Denominator zero is not possible");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}