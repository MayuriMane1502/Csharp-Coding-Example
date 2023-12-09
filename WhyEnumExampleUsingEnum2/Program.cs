using System;
public class Program
{
    public static void Main()
    {
        int[] values = (int[])Enum.GetValues(typeof(Gender)); // if you customize the datatype below the also needs to change the int to short
        foreach(int value in values)
        {
            Console.WriteLine(value);
        }
        string[] Names = (string[])Enum.GetNames(typeof(Gender));
        foreach(string Name in Names)
        {
            Console.WriteLine(Name);
        }
    }
}

public enum Gender //: short - you can customize the datatype and underlying values
{
    Unknown, //unknown = 25
    Male, //Male =3
    Female // Female = 45 ---this values also possible
}