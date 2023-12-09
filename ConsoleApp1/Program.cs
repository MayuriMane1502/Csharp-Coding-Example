using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Circle
    {
        float _PI = 3.141F;
        int _Radius;

        public Circle(int Radius) // constructor
        {
            this._Radius = Radius;
        }
        public float CalculateArea()
        {
            return this._PI * this._Radius * this._Radius;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Circle C1 = new Circle(5); // creating a object
            float Area = C1.CalculateArea();

            Console.WriteLine("Area = {0}", Area);

            Circle C2 = new Circle(6); // creating a object
            float Area2 = C2.CalculateArea();

            Console.WriteLine("Area2 = {0}", Area2);
        }
    }
}
