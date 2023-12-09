//getter and setter methods are used
using System;

public class Student
{
    private int _id;
    private string _Name;
    private int _passMarks = 35;

    public void SetId (int Id)
    {
        if(Id <= 0)
        {
            throw new Exception("Student Id can not be negative");
        }
        this._id = Id;
    }

    public int GetId()
    {
        return this._id;
    }

    public void SetName (string Name)
    {
        if(string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be empty");
        }
        this._Name = Name;
    }

    public string GetName()
    {
        //also instead of below if-else condition we can use ternary operator
        return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;

        /*if (string.IsNullOrEmpty(this._Name))
        {
            return "No Name";
        }
        else
        {
            return this._Name;
        }*/
    }
    public int GetPassMarks()
    {
        return this._passMarks;
    }
}
public class Program
{
    public static void Main()
    {
        Student S1 = new Student(); 
        S1.SetId(101);
        S1.SetName("Mayuri");
        //S1.PassMarks = 0;*/

       Console.WriteLine("ID= {0} && Name= {1} && PassMarks = {2}", S1.GetId(), S1.GetName(), S1.GetPassMarks());
    }
}