using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    #region Decorator
    //public abstract class Component
    //{
    //    public abstract void Operation();
    //}

    //public class ConcreteComponent : Component
    //{
    //    public override void Operation()
    //    {
    //        Console.WriteLine("Operation of specific object instance.");
    //    }
    //}

    //public abstract class Decorator : Component
    //{
    //    protected Component Component;

    //    public void SetComponent(Component component)
    //    {
    //        Component = component;
    //    }

    //    public override void Operation()
    //    {
    //        if (Component != null)
    //        {
    //            Component.Operation();
    //        }
    //    }
    //}

    //public class ConcreteDecoratorA : Decorator
    //{
    //    //Unique field that is different with the other concrete decorator classes.
    //    private string addedState;

    //    public override void Operation()
    //    {
    //        base.Operation();
    //        addedState = "New State";
    //        Console.WriteLine("Equippment of specific instance of ConcreteDecoratorA");
    //    }
    //}

    //public class ConcreteDecoratorB : Decorator
    //{
    //    public override void Operation()
    //    {
    //        base.Operation();
    //        AddedBehavior();
    //        Console.WriteLine("Equippment of specific instance of ConcreteDecoratorB");
    //    }

    //    //Unique method that is different with the other concrete decorator classes.
    //    private void AddedBehavior()
    //    {

    //    }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        var cComponent = new ConcreteComponent();
    //        var decorator1 = new ConcreteDecoratorA();
    //        var decorator2 = new ConcreteDecoratorB();

    //        decorator1.SetComponent(cComponent);
    //        decorator2.SetComponent(decorator1);
    //        decorator2.Operation();
    //    }
    //}
    #endregion
}
