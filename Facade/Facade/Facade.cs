using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
        }

        public void MethodA()
        {
            Console.WriteLine("\n Method A ----");
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
        }

        public void MethodB()
        {
            Console.WriteLine("\n Method B ----");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
