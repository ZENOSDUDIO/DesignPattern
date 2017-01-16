using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            //Console.WriteLine("Please input number A: ");
            //string a = Console.ReadLine();
            //Console.WriteLine("Please input operator (+, -, *, /): ");
            //string b = Console.ReadLine();
            //Console.WriteLine("Please input number B: ");
            //string c = Console.ReadLine();
            //string d = string.Empty;

            //if (b == "+")
            //{
            //    d = Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(c));
            //}
            
            //if (b == "-")
            //{
            //    d = Convert.ToString(Convert.ToDouble(a) - Convert.ToDouble(c));
            //}
            
            //if (b == "*")
            //{
            //    d = Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(c));
            //}
            
            //if (b == "/")
            //{
            //    d = Convert.ToString(Convert.ToDouble(a) / Convert.ToDouble(c));
            //}

            //Console.WriteLine("Result is {0}", d);

            #region Issues
            /*
             1. Variable name definition
             2. Duplicated if branch
             3. No validation for user input
             */
            #endregion
            #endregion

            #region Ver 2
            //try
            //{
            //    Console.WriteLine("Please input number A: ");
            //    string numberA = Console.ReadLine();
            //    Console.WriteLine("Please input operator (+, -, *, /): ");
            //    string inputOperator = Console.ReadLine();
            //    Console.WriteLine("Please input number B: ");
            //    string numberB = Console.ReadLine();
            //    string result = string.Empty;

            //    switch (inputOperator)
            //    {
            //        case "+":
            //            result = Convert.ToString(Convert.ToDouble(numberA) + Convert.ToDouble(numberB));
            //            break;
            //        case "-":
            //            result = Convert.ToString(Convert.ToDouble(numberA) - Convert.ToDouble(numberB));
            //            break;
            //        case "*":
            //            result = Convert.ToString(Convert.ToDouble(numberA) * Convert.ToDouble(numberB));
            //            break;
            //        case "/":
            //            if (numberB != "0")
            //            {
            //                result = Convert.ToString(Convert.ToDouble(numberA) / Convert.ToDouble(numberB));
            //            }
            //            else
            //            {
            //                result = "Divisor cannot be zero.";
            //            }
            //            break;
            //    }

            //    Console.WriteLine("Result is {0}", result);
            //}
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine("Input incorrect: {0}.", ex.Message);
            //}

            #region Issues
            /*
             1. Reusable?
             */
            #endregion
            #endregion

            #region Ver 3
            //try
            //{
            //    Console.WriteLine("Please input number A: ");
            //    string numberA = Console.ReadLine();
            //    Console.WriteLine("Please input operator (+, -, *, /): ");
            //    string inputOperator = Console.ReadLine();
            //    Console.WriteLine("Please input number B: ");
            //    string numberB = Console.ReadLine();
            //    string result = string.Empty;

            //    result = Operation.GetResult(Convert.ToDouble(numberA)
            //        , Convert.ToDouble(numberB)
            //        , inputOperator).ToString();

            //    Console.WriteLine("Result is {0}", result);
            //}
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine("Input incorrect: {0}.", ex.Message);
            //}

            #region Issues
            /*
             1. OO?
             */
            #endregion
            #endregion

            #region Ver 4
            //try
            //{
            //    Operation op = OperationFactory.CreateOperation("+");
            //    op.NumberA = 1;
            //    op.NumberB = 2;

            //    Console.WriteLine("Result is {0}", op.GetResult());
            //}
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine("Input incorrect: {0}.", ex.Message);
            //}

            #region Issues
            /*
             NA
             */
            #endregion
            #endregion
        }
    }
}
