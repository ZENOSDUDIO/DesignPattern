using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    #region Ver 2
    //public class Proxy
    //{
    //    private SchoolGirl mm;

    //    public Proxy(SchoolGirl mm)
    //    {
    //        this.mm = mm;
    //    }

    //    public void GiveDolls()
    //    {
    //        Console.WriteLine(string.Format("{0}, give you the dolls.", mm.Name));
    //    }

    //    public void GiveFlowers()
    //    {
    //        Console.WriteLine(string.Format("{0}, give you the flowers.", mm.Name));
    //    }

    //    public void GiveChocolate()
    //    {
    //        Console.WriteLine(string.Format("{0}, give you the chocolate.", mm.Name));
    //    }
    //}
    #endregion

    #region Ver 3
    //public class Proxy : IGiveGift
    //{
    //    private Pursuer gg;

    //    public Proxy(SchoolGirl mm)
    //    {
    //        gg = new Pursuer(mm);
    //    }

    //    public void GiveDolls()
    //    {
    //        gg.GiveDolls();
    //    }

    //    public void GiveFlowers()
    //    {
    //        gg.GiveFlowers();
    //    }

    //    public void GiveChocolate()
    //    {
    //        gg.GiveChocolate();
    //    }
    //}
    #endregion

    #region Proxy
    //public abstract class Subject
    //{
    //    public abstract void Request();
    //}

    //public class RealSubject : Subject
    //{
    //    public override void Request()
    //    {
    //        Console.WriteLine("Real request");
    //    }
    //}

    //public class Proxy : Subject
    //{
    //    private RealSubject realSubject;

    //    public override void Request()
    //    {
    //        if (realSubject == null)
    //        {
    //            realSubject = new RealSubject();
    //        }

    //        realSubject.Request();
    //    }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        var proxy = new Proxy();
    //        proxy.Request();
    //    }
    //}
    #endregion
}
