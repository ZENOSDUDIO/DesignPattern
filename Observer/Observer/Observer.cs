using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    #region Ver 1
    public class StockObserver
    {
        public Secretary Secretary { get; set; }
        public string Name { get; set; }

        public StockObserver(string name, Secretary secretary)
        {
            Name = name;
            Secretary = secretary;
        }

        public void Update()
        {
            Console.WriteLine("{0} {1}. Stop watching Stock! Back to work!", Secretary.SecretaryAction, Name);
        }
    }
    #endregion

    #region Ver 2
    //public abstract class Observer
    //{
    //    public string Name { get; set; }
    //    public Secretary Secretary { get; set; }

    //    public Observer(string name, Secretary secretary)
    //    {
    //        Name = name;
    //        Secretary = secretary;
    //    }

    //    public abstract void Update();
    //}

    //public class StockObserver : Observer
    //{
    //    public StockObserver(string name, Secretary secretary) : base(name, secretary) { }

    //    public override void Update()
    //    {
    //        Console.WriteLine("{0} {1}. Stop watching Stock! Back to work!", Secretary.SecretaryAction, Name);
    //    }
    //}


    //public class NBAObserver : Observer
    //{
    //    public NBAObserver(string name, Secretary secretary) : base(name, secretary) { }

    //    public override void Update()
    //    {
    //        Console.WriteLine("{0} {1}. Stop watching NBA! Back to work!", Secretary.SecretaryAction, Name);
    //    }
    //}
    #endregion

    #region Ver 3
    //public abstract class Observer
    //{
    //    public string Name { get; set; }
    //    public ISubject Subject { get; set; }

    //    public Observer(string name, ISubject subject)
    //    {
    //        Name = name;
    //        Subject = subject;
    //    }

    //    public abstract void Update();
    //}

    //public class StockObserver : Observer
    //{
    //    public StockObserver(string name, ISubject subject) : base(name, subject) { }

    //    public override void Update()
    //    {
    //        Console.WriteLine("{0} {1}. Stop watching Stock! Back to work!", Subject.SubjectState, Name);
    //    }
    //}


    //public class NBAObserver : Observer
    //{
    //    public NBAObserver(string name, ISubject subject) : base(name, subject) { }

    //    public override void Update()
    //    {
    //        Console.WriteLine("{0} {1}. Stop watching NBA! Back to work!", Subject.SubjectState, Name);
    //    }
    //}
    #endregion

    #region Ver 4
    //public abstract class Observer
    //{
    //    public string Name { get; set; }
    //    public ISubject Subject { get; set; }

    //    public Observer(string name, ISubject subject)
    //    {
    //        Name = name;
    //        Subject = subject;
    //    }

    //    public abstract void Update();
    //}

    //public class StockObserver : Observer
    //{
    //    public StockObserver(string name, ISubject subject) : base(name, subject) { }

    //    public override void Update()
    //    {
    //        Console.WriteLine("{0} {1}. Stop watching Stock! Back to work!", Subject.SubjectState, Name);
    //    }

    //    public void CloseBrowser() { }
    //}


    //public class NBAObserver : Observer
    //{
    //    public NBAObserver(string name, ISubject subject) : base(name, subject) { }

    //    public override void Update()
    //    {
    //        Console.WriteLine("{0} {1}. Stop watching NBA! Back to work!", Subject.SubjectState, Name);
    //    }

    //    public void ShutdownPlayer() { }
    //}
    #endregion

    #region Observer
    //public abstract class Subject
    //{
    //    private IList<Observer> obervers = new List<Observer>();

    //    public void Attach(Observer observer)
    //    {
    //        obervers.Add(observer);
    //    }

    //    public void Detach(Observer observer)
    //    {
    //        obervers.Remove(observer);
    //    }

    //    public void Notify()
    //    {
    //        foreach (var o in obervers)
    //        {
    //            o.Update();
    //        }
    //    }
    //}

    //public abstract class Observer
    //{
    //    public abstract void Update();
    //}

    //public class ConcreteSubject : Subject
    //{
    //    public string SubjectState { get; set; }
    //}

    //public class ConcreteObserver : Observer
    //{
    //    public ConcreteSubject Subject { get; set; }
    //    private string name;
    //    private string observerState;

    //    public ConcreteObserver(ConcreteSubject subject, string name)
    //    {
    //        Subject = subject;
    //        this.name = name;
    //    }

    //    public override void Update()
    //    {
    //        observerState = Subject.SubjectState;
    //        Console.WriteLine("Observer {0} new state is {1}", name, observerState);
    //    }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        var s = new ConcreteSubject();
    //        s.Attach(new ConcreteObserver(s, "X"));
    //        s.Attach(new ConcreteObserver(s, "Y"));
    //        s.Attach(new ConcreteObserver(s, "Z"));

    //        s.SubjectState = "ABC";
    //        s.Notify();
    //    }
    //}
    #endregion
}
