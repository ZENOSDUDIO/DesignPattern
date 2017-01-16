using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    #region Composite
    public abstract class Component
    {
        protected string Name;

        public Component(string name)
        {
            Name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }

    public class Composite : Component
    {
        private IList<Component> childen = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component c)
        {
            childen.Add(c);
        }

        public override void Remove(Component c)
        {
            childen.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var component in childen)
            {
                component.Display(depth + 2);
            }
        }
    }

    public class Client
    {
        public void DoWork()
        {
            var root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);

            var comp2 = new Composite("Composite XY");
            comp2.Add(new Leaf("Leaf XYA"));
            comp2.Add(new Leaf("Leaf XYB"));
            comp.Add(comp2);

            root.Add(new Leaf("Leaf C"));

            root.Display(1);
        }
    }
    #endregion
}
