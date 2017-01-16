using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    #region Mediator
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 colleague1;
        private ConcreteColleague2 colleague2;

        public void SetConcreteColleague1(ConcreteColleague1 colleague1)
        {
            this.colleague1 = colleague1;
        }

        public void SetConcreteColleague2(ConcreteColleague2 colleague2)
        {
            this.colleague2 = colleague2;
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == colleague1)
            {
                colleague2.Notify(message);
            }
            else
            {
                colleague1.Notify(message);
            }
        }
    }

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 receives message:" + message);
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 receives message:" + message);
        }
    }
    #endregion
}
