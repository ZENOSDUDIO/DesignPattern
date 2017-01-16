using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    #region Adapter
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Normal Request");
        }
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Specific Request");
        }
    }

    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    public class Client
    {
        public void DoWork()
        {
            Target target = new Adapter();
            target.Request();
        }
    }
    #endregion
}
