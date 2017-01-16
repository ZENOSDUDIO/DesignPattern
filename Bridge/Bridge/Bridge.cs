using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    #region Bridge
    //public abstract class Implementor
    //{
    //    public abstract void Operation();
    //}

    //public class ConcreteImplementorA : Implementor
    //{
    //    public override void Operation()
    //    {
    //        Console.WriteLine("The impementation of Operation method in class A");
    //    }
    //}

    //public class ConcreteImplementorB : Implementor
    //{
    //    public override void Operation()
    //    {
    //        Console.WriteLine("The impementation of Operation method in class B");
    //    }
    //}

    //public class Abstraction
    //{
    //    protected Implementor Implementor;

    //    public void SetImplementor(Implementor implementor)
    //    {
    //        Implementor = implementor;
    //    }

    //    public virtual void Operation()
    //    {
    //        Implementor.Operation();
    //    }
    //}

    //public class RefineAbstraction : Abstraction
    //{
    //    public override void Operation()
    //    {
    //        Implementor.Operation();
    //    }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        Abstraction ab = new RefineAbstraction();
    //        ab.SetImplementor(new ConcreteImplementorA());
    //        ab.Operation();

    //        ab.SetImplementor(new ConcreteImplementorB());
    //        ab.Operation();
    //    }
    //}
    #endregion
}
