//instead of getter and setter methods we are using get and set properties
using System;

public class Student
{
    private int _id;
    private string _Name;
    private int _passMarks = 35;

    public int Id
    {
        set 
        {
            if (value <= 0) // value is the keyword used in set/get property here the value we are assigning to the ID field will be going inside the value field and compare
            {
                throw new Exception("Student Id can not be negative");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
        
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be empty");
            }
            this._Name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
    }

    
    public int PassMarks
    {
        set
        {
            return this._passMarks;
        }       
    }
}
public class Program
{
    public static void Main()
    {
        Student S1 = new Student();
        S1.Id=101;
        S1.Name="Mayuri";
        //S1.PassMarks = 0;*/

        Console.WriteLine("ID = {0}", S1.Id);
        Console.WriteLine("Name = {1}", S1.Name);
        Console.WriteLine("PassMarks = {2}", S1.PassMarks);
        //Console.WriteLine("ID= {0}  Name= {1} && PassMarks = {2}", S1.GetId(), S1.GetName(), S1.GetPassMarks());
    }
}