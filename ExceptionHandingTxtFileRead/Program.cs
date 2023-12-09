using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"C:\Users\hp\Desktop\Data.txt");//to get exception change the file name - data1.txt
            Console.WriteLine(streamReader.ReadToEnd());
            //streamReader.Close(); //exception occured then program will terminiate at line 10 so it will not close the source file
            // it is necessary to close that so we need to add this line to finally block
        }
        //catch(Exception ex)
        catch(FileNotFoundException ex)
        {
            /*
            Console.WriteLine(ex.Message); // will display exception msg
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);//display exact line where exception happened
            */
            Console.WriteLine("Please check if the file {0} exists ", ex.FileName);
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
        finally // finally block will always executed irrespective of try and catch block
        //so need to close the resource in finally blk
        {
            if(streamReader != null)
            {
                streamReader.Close();
            }
            
            Console.WriteLine("finally block");
        }
    }
}