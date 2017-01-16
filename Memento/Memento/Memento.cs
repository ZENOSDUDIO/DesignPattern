using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    #region Memento
    //public class Originator
    //{
    //    public string State { get; set; }

    //    public Memento CreateMemento()
    //    {
    //        return (new Memento(State));
    //    }

    //    public void SetMemento(Memento memento)
    //    {
    //        State = memento.State;
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine("State = {0}", State);
    //    }
    //}

    //public class Memento
    //{
    //    public string  State { get; private set; }

    //    public Memento(string state)
    //    {
    //        State = state;
    //    }
    //}

    //public class CareTaker
    //{
    //    public Memento Memento { get; set; }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        var o = new Originator();
    //        o.State = "On";
    //        o.Show();

    //        var c = new CareTaker();
    //        c.Memento = o.CreateMemento();

    //        o.State = "Off";
    //        o.Show();

    //        o.SetMemento(c.Memento);
    //        o.Show();
    //    }
    //}
    #endregion
}
