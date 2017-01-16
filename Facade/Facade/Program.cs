using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new Facade();
            facade.MethodA();
            facade.MethodB();
        }
    }
}
