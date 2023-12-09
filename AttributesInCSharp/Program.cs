using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
       // Calculator.Add(10, 20); // outdated methos so showing obsolete
       Calculator.Add(new List<int> { 10, 20,30 });
    }
}

public class Calculator
{
    [Obsolete("Use Add(List<int> Numbers) Method ")] //used this parameter to add some declarative information
    //[Obsolete("Use Add(List<int> Numbers) Method ", true)] // it will show error instead of warning to old add method
    public static int Add(int FirstNumber,  int SecondNumber) //this method can only add 2 numbers
    {
        return FirstNumber + SecondNumber;
    }
    public static int Add(List<int> Numbers) // this method can any numbers of number
    {
        int Sum = 0;
        foreach (int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
    }
}