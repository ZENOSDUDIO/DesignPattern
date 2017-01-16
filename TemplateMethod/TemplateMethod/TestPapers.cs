using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    #region Ver 1
    public class TestPaperA
    {
        public void TestQuestion1()
        {
            Console.WriteLine("1 + 1 = ; a.1 b.2 c.3 d.4");
            Console.WriteLine("The answer is b.");
        }

        public void TestQuestion2()
        {
            Console.WriteLine("1 + 2 = ; a.1 b.2 c.3 d.4");
            Console.WriteLine("The answer is c.");
        }

        public void TestQuestion3()
        {
            Console.WriteLine("1 + 3 = ; a.1 b.2 c.3 d.4");
            Console.WriteLine("The answer is d.");
        }
    }

    public class TestPaperB
    {
        public void TestQuestion1()
        {
            Console.WriteLine("1 + 1 = ; a.1 b.2 c.3 d.4");
            Console.WriteLine("The answer is a.");
        }

        public void TestQuestion2()
        {
            Console.WriteLine("1 + 2 = ; a.1 b.2 c.3 d.4");
            Console.WriteLine("The answer is c.");
        }

        public void TestQuestion3()
        {
            Console.WriteLine("1 + 3 = ; a.1 b.2 c.3 d.4");
            Console.WriteLine("The answer is c.");
        }
    }
    #endregion

    #region Ver 2
    //public class TestPaper
    //{
    //    public void TestQuestion1()
    //    {
    //        Console.WriteLine("1 + 1 = ; a.1 b.2 c.3 d.4");
    //    }

    //    public void TestQuestion2()
    //    {
    //        Console.WriteLine("1 + 2 = ; a.1 b.2 c.3 d.4");
    //    }

    //    public void TestQuestion3()
    //    {
    //        Console.WriteLine("1 + 3 = ; a.1 b.2 c.3 d.4");
    //    }
    //}

    //public class TestPaperA : TestPaper
    //{
    //    public new void TestQuestion1()
    //    {
    //        base.TestQuestion1();
    //        Console.WriteLine("The answer is b.");
    //    }

    //    public new void TestQuestion2()
    //    {
    //        base.TestQuestion2();
    //        Console.WriteLine("The answer is c.");
    //    }

    //    public new void TestQuestion3()
    //    {
    //        base.TestQuestion3();
    //        Console.WriteLine("The answer is d.");
    //    }
    //}

    //public class TestPaperB : TestPaper
    //{
    //    public new void TestQuestion1()
    //    {
    //        base.TestQuestion1();
    //        Console.WriteLine("The answer is b.");
    //    }

    //    public new void TestQuestion2()
    //    {
    //        base.TestQuestion2();
    //        Console.WriteLine("The answer is c.");
    //    }

    //    public new void TestQuestion3()
    //    {
    //        base.TestQuestion3();
    //        Console.WriteLine("The answer is d.");
    //    }
    //}
    #endregion

    #region Ver 3
    //public class TestPaper
    //{
    //    public void TestQuestion1()
    //    {
    //        Console.WriteLine("1 + 1 = ; a.1 b.2 c.3 d.4");
    //        Console.WriteLine("The answer is: {0}", Answer1());
    //    }

    //    protected virtual string Answer1()
    //    {
    //        return string.Empty;
    //    }
    //}

    //public class TestPaperA : TestPaper
    //{
    //    protected override string Answer1()
    //    {
    //        return "b";
    //    }
    //}

    //public class TestPaperB : TestPaper
    //{
    //    protected override string Answer1()
    //    {
    //        return "c";
    //    }
    //}
    #endregion
}
