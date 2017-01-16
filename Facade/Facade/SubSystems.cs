using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("SubSystem Method One");
        }
    }

    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("SubSystem Method Two");
        }
    }


    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("SubSystem Method Three");
        }
    }
}
