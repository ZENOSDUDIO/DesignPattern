using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public abstract class UnitedNations
    {
        public abstract void Declare(string message, Country colleague);
    }

    public abstract class Country
    {
        protected UnitedNations Mediator;

        public Country(UnitedNations mediator)
        {
            Mediator = mediator;
        }
    }

    public class USA : Country
    {
        public USA(UnitedNations mediator) : base(mediator) { }

        public void Declare(string message)
        {
            Mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("USA got the message: " + message);
        }
    }

    public class Iraq : Country
    {
        public Iraq(UnitedNations mediator) : base(mediator) { }

        public void Declare(string message)
        {
            Mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("Iraq got the message: " + message);
        }
    }

    public class UnitedNationsSeccurityCouncil : UnitedNations
    {
        private USA colleague1;
        private Iraq colleague2;

        public void SetColleague1(USA colleague1)
        {
            this.colleague1 = colleague1;
        }

        public void SetColleague2(Iraq colleague2)
        {
            this.colleague2 = colleague2;
        }

        public override void Declare(string message, Country colleague)
        {
            if (colleague == colleague1)
            {
                colleague2.GetMessage(message);
            }
            else
            {
                colleague1.GetMessage(message);
            }
        }
    }

}
