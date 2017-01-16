using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1 & 2
            var studentA = new TestPaperA();
            studentA.TestQuestion1();
            studentA.TestQuestion2();
            studentA.TestQuestion3();

            var studentB = new TestPaperB();
            studentB.TestQuestion1();
            studentB.TestQuestion2();
            studentB.TestQuestion3();
            #endregion

            #region Ver 3
            //TestPaper studentA = new TestPaperA();
            //studentA.TestQuestion1();

            //TestPaper studentB = new TestPaperB();
            //studentB.TestQuestion1();
            #endregion
        }
    }
}
