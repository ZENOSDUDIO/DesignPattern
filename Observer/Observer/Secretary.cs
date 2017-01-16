using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    #region Ver 1
    public class Secretary
    {
        public string SecretaryAction { get; set; }
        private IList<StockObserver> observers = new List<StockObserver>();

        public void Attach(StockObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
    #endregion

    #region Ver 2
    //public class Secretary
    //{
    //    public string SecretaryAction { get; set; }
    //    private IList<Observer> observers = new List<Observer>();

    //    public void Attach(Observer observer)
    //    {
    //        observers.Add(observer);
    //    }

    //    public void Detach(Observer observer)
    //    {
    //        observers.Remove(observer);
    //    }

    //    public void Notify()
    //    {
    //        foreach (var item in observers)
    //        {
    //            item.Update();
    //        }
    //    }
    //}
    #endregion

    #region Ver 3
    //public interface ISubject
    //{
    //    void Attach(Observer observer);
    //    void Detach(Observer observer);
    //    void Notify();

    //    string SubjectState { get; set; }
    //}

    //public class Boss : ISubject
    //{
    //    private IList<Observer> observers = new List<Observer>();
    //    private string action;

    //    public void Attach(Observer observer)
    //    {
    //        observers.Add(observer);
    //    }

    //    public void Detach(Observer observer)
    //    {
    //        observers.Remove(observer);
    //    }

    //    public void Notify()
    //    {
    //        foreach (var item in observers)
    //        {
    //            item.Update();
    //        }
    //    }

    //    public string SubjectState
    //    {
    //        get
    //        {
    //            return action;
    //        }
    //        set
    //        {
    //            action = value;
    //        }
    //    }
    //}
    #endregion

    #region Ver 4
    //public interface ISubject
    //{
    //    void Notify();

    //    string SubjectState { get; set; }
    //}

    //public delegate void EventHandler();

    //public class Boss : ISubject
    //{
    //    public event EventHandler Update;
    //    private IList<Observer> observers = new List<Observer>();
    //    private string action;

    //    public void Notify()
    //    {
    //        Update();
    //    }

    //    public string SubjectState
    //    {
    //        get
    //        {
    //            return action;
    //        }
    //        set
    //        {
    //            action = value;
    //        }
    //    }
    //}
    #endregion
}
