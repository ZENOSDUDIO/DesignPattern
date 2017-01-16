using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class Operation
    {
        #region Ver 3
        //public static double GetResult(double numberA, double numberB, string inputOperator)
        //{
        //    double result = 0d;

        //    switch (inputOperator)
        //    {
        //        case "+":
        //            result = numberA + numberB;
        //            break;
        //        case "-":
        //            result = numberA - numberB;
        //            break;
        //        case "*":
        //            result = numberA * numberB;
        //            break;
        //        case "/":
        //            result = numberA / numberB;
        //            break;
        //    }

        //    return result;
        //}
        #endregion

        #region Ver 4
        //public double NumberA { get; set; }
        //public double NumberB { get; set; }

        //public virtual double GetResult()
        //{
        //    return 0;
        //}
        #endregion
    }
}
