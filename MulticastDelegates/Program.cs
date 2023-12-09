using System;

public delegate void SampleDelegate(); //1 - create delegate 

public class Program
{
   public static void Main()
    {
        /*SampleDelegate del = new SampleDelegate(SampleMethodOne); //3 create instance of delegate- pass methodname as parameter
        del();*/
        SampleDelegate del1, del2, del3, del4;
        del1 = new SampleDelegate(SampleMethodOne); //assigning delegates to methods
        del2 = new SampleDelegate(SampleMethodTwo);
        del3 = new SampleDelegate(SampleMethodThree);

        /* another way of delegate
         SampleDelegate del = new SampleDelegate(SampleMethodOne);
        del += SampleMethodTwo;
        del += SampleMethodThree;

        del(); // it will invoke all three methods
         
         
         */

        del4 = del1 + del2 + del3;// if we want del 1 & del 3 only then you can remove the del2 using [ - del2] sign
        del4();//it will invoke all del1,del2,del3 methods - it is multicast delegate
    }
    public static void SampleMethodOne() // 2 - create method
    {
        Console.WriteLine("Sample Method One Invoked");
    }
    public static void SampleMethodTwo() 
    {
        Console.WriteLine("Sample Method Two Invoked");
    }
    public static void SampleMethodThree()
    {
        Console.WriteLine("Sample Method Three Invoked");
    }
}