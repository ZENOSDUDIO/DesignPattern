using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsibilityChain
{
    #region ResponsibilityChain
    //public abstract class Handler
    //{
    //    protected Handler Successor;

    //    public void SetSuccessor(Handler successor)
    //    {
    //        Successor = successor;
    //    }

    //    public abstract void HandleRequest(int request);
    //}

    //public class ConcreteHandler1 : Handler
    //{
    //    public override void HandleRequest(int request)
    //    {
    //        if (request >= 0 && request < 10)
    //        {
    //            Console.WriteLine("{0} handles this request {1}", GetType().Name, request);
    //        }
    //        else if (Successor != null)
    //        {
    //            Successor.HandleRequest(request);
    //        }
    //    }
    //}

    //public class ConcreteHandler2 : Handler
    //{
    //    public override void HandleRequest(int request)
    //    {
    //        if (request >= 10 && request < 20)
    //        {
    //            Console.WriteLine("{0} handles this request {1}", GetType().Name, request);
    //        }
    //        else if (Successor != null)
    //        {
    //            Successor.HandleRequest(request);
    //        }
    //    }
    //}

    //public class ConcreteHandler3 : Handler
    //{
    //    public override void HandleRequest(int request)
    //    {
    //        if (request >= 20 && request < 30)
    //        {
    //            Console.WriteLine("{0} handles this request {1}", GetType().Name, request);
    //        }
    //        else if (Successor != null)
    //        {
    //            Successor.HandleRequest(request);
    //        }
    //    }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        var h1 = new ConcreteHandler1();
    //        var h2 = new ConcreteHandler2();
    //        var h3 = new ConcreteHandler3();

    //        h1.SetSuccessor(h2);
    //        h2.SetSuccessor(h3);

    //        int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

    //        foreach (var request in requests)
    //        {
    //            h1.HandleRequest(request);
    //        }
    //    }
    //}
    #endregion
}
