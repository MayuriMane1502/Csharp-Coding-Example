using System;
using System.IO;

public class Program
{ 
    public static void Main()
    {
        try
        {
            try
            {
                Console.WriteLine("Enter the First Number: ");
                int FN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Number: ");
                int SN = Convert.ToInt32(Console.ReadLine());

                int Result = FN / SN;

                Console.WriteLine("Result: {0}", Result);
            }
            catch (Exception ex) // exception occured then WriteLine msg will be seen on to the console screen
                                 //but the actual exception details will be stored in the Log.txt file
            {
                string filePath = @"F:\.NET Coding course\Log1.txt"; //Log.txt file present
                //first need to check whether the file is present or not 7 throw an exception accordingly
                if (File.Exists(filePath))
                {

                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.Write('\n');
                    sw.Write(ex.Message);
                    sw.Write('\n');
                    sw.Write(ex.StackTrace);
                    sw.Close();

                    Console.WriteLine("There is a Problem, Please try later");
                }
                else
                {
                    throw new FileNotFoundException(filePath + "is not present",ex);//ex is the main exception inside that we have another exception file not found
                     //throw new FileNotFoundException(filePath + "is not present");
                    //above if we are not passing any ex parameter then below inner exception shows null value
                }
            }
        }
        catch(Exception exception)
        {
            Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
            }
        }

    }
}