using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    #region Strategy
    //public abstract class Strategy
    //{
    //    public abstract string AlgorithmInterface();
    //}

    //public class ConcreteStrategyA : Strategy
    //{
    //    public override string AlgorithmInterface()
    //    {
    //        return "Algorithm A implemented.";
    //    }
    //}

    //public class ConcreteStrategyB : Strategy
    //{
    //    public override string AlgorithmInterface()
    //    {
    //        return "Algorithm B implemented.";
    //    }
    //}

    //public class ConcreteStrategyC : Strategy
    //{
    //    public override string AlgorithmInterface()
    //    {
    //        return "Algorithm C implemented.";
    //    }
    //}

    //public class Context
    //{
    //    private Strategy strategy;

    //    public Context(Strategy strategy)
    //    {
    //        this.strategy = strategy;
    //    }

    //    public string ContextInterface()
    //    {
    //        return strategy.AlgorithmInterface();
    //    }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        Context context = null;

    //        context = new Context(new ConcreteStrategyA());
    //        context.ContextInterface();

    //        context = new Context(new ConcreteStrategyB());
    //        context.ContextInterface();

    //        context = new Context(new ConcreteStrategyC());
    //        context.ContextInterface();
    //    }
    //}
    #endregion
}
