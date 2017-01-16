using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    #region Ver 4
    //public class OperationAdd : Operation
    //{
    //    public override double GetResult()
    //    {
    //        return NumberA + NumberB;
    //    }
    //}

    //public class OperationSub : Operation
    //{
    //    public override double GetResult()
    //    {
    //        return NumberA - NumberB;
    //    }
    //}

    //public class OperationMul : Operation
    //{
    //    public override double GetResult()
    //    {
    //        return NumberA * NumberB;
    //    }
    //}

    //public class OperationDiv : Operation
    //{
    //    public override double GetResult()
    //    {
    //        if (NumberB == 0)
    //        {
    //            throw new Exception("Divisor cannot be zero.");
    //        }

    //        return NumberA / NumberB;
    //    }
    //}

    //public class OperationFactory
    //{
    //    public static Operation CreateOperation(string inputOperator)
    //    {
    //        Operation op = null;

    //        switch (inputOperator)
    //        {
    //            case "+":
    //                op = new OperationAdd();
    //                break;
    //            case "-":
    //                op = new OperationSub();
    //                break;
    //            case "*":
    //                op = new OperationMul();
    //                break;
    //            case "/":
    //                op = new OperationDiv();
    //                break;
    //        }

    //        return op;
    //    }
    //}
    #endregion
}
