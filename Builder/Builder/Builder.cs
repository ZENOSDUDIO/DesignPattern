using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    #region Builder
    //public class Product
    //{
    //    private IList<string> parts = new List<string>();

    //    public void Add(string part)
    //    {
    //        parts.Add(part);
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine("\n Product create -----");

    //        foreach (var part in parts)
    //        {
    //            Console.WriteLine(part);
    //        }
    //    }
    //}

    //public abstract class Builder
    //{
    //    public abstract void BuildPartA();
    //    public abstract void BuildPartB();
    //    public abstract Product GetResult();
    //}

    //public class ConcreteBuilder1 : Builder
    //{
    //    private Product product = new Product();

    //    public override void BuildPartA()
    //    {
    //        product.Add("Part A");
    //    }

    //    public override void BuildPartB()
    //    {
    //        product.Add("Part B");
    //    }

    //    public override Product GetResult()
    //    {
    //        return product;
    //    }
    //}

    //public class ConcreteBuilder2 : Builder
    //{
    //    private Product product = new Product();

    //    public override void BuildPartA()
    //    {
    //        product.Add("Part X");
    //    }

    //    public override void BuildPartB()
    //    {
    //        product.Add("Part Y");
    //    }

    //    public override Product GetResult()
    //    {
    //        return product;
    //    }
    //}

    //public class Director
    //{
    //    public void Construct(Builder builder)
    //    {
    //        builder.BuildPartA();
    //        builder.BuildPartB();
    //    }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        var director = new Director();
    //        Builder b1 = new ConcreteBuilder1();
    //        Builder b2 = new ConcreteBuilder2();

    //        director.Construct(b1);
    //        var p1 = b1.GetResult();
    //        p1.Show();

    //        director.Construct(b2);
    //        var p2 = b1.GetResult();
    //        p2.Show();
    //    }
    //}
    #endregion
}
