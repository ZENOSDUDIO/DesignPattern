using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    #region Iterator
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            current++;

            if (current < aggregate.Count)
            {
                ret = aggregate[current];
            }

            return ret;
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }

    public class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        public object this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items.Insert(index, value);
            }
        }
    }

    public class Client
    {
        public void DoWork()
        {
            var agg = new ConcreteAggregate();
            agg[0] = "Data1";
            agg[0] = "Data2";
            agg[0] = "Data3";

            Iterator iterator = new ConcreteIterator(agg);
            var item = iterator.First();

            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.CurrentItem());
                iterator.Next();
            }
        }
    }
    #endregion
}
