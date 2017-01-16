using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    #region Prototype
    //public abstract class Prototype
    //{
    //    public string ID { get; set; }

    //    public Prototype(string id)
    //    {
    //        ID = id;
    //    }

    //    public abstract Prototype Clone();
    //}

    //public class ConcretePrototype1 : Prototype
    //{
    //    public ConcretePrototype1(string id) : base(id) { }

    //    public override Prototype Clone()
    //    {
    //        return (Prototype)MemberwiseClone();
    //    }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        var p1 = new ConcretePrototype1("I");
    //        var c1 = (ConcretePrototype1)p1.Clone();
    //        Console.WriteLine("Cloned: {0}", c1.ID);
    //    }
    //}
    #endregion
}
