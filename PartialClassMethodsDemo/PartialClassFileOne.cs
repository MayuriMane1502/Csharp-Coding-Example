using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassMethodsDemo
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();

       /* partial void SamplePartialMethod()
        {
            Console.WriteLine("Sample Partial Method Invoked");
        }*/ //we can do implementation in same file or definiation in one file and implementation in another file.

        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            SamplePartialMethod();
        }

    }
}
