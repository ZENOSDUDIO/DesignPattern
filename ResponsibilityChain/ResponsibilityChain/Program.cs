using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsibilityChain
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            var manager1 = new Manager("Adam");
            var manager2 = new Manager("Martin");
            var manager3 = new Manager("Declan");

            var request1 = new Request
            {
                Quantity = 1000,
                RequestType = RequestType.SalaryIncrease,
                RequestContent = "Karl asks salary increase."
            };

            manager1.GetResult(ManagerLevel.Manager, request1);
            manager2.GetResult(ManagerLevel.Director, request1);
            manager3.GetResult(ManagerLevel.Head, request1);

            var manager4 = new Manager("Adam");
            var manager5 = new Manager("Martin");
            var manager6 = new Manager("Declan");

            var request2 = new Request
            {
                Quantity = 3,
                RequestType = RequestType.Leave,
                RequestContent = "Beck asks for leave."
            };

            manager4.GetResult(ManagerLevel.Manager, request2);
            manager5.GetResult(ManagerLevel.Director, request2);
            manager6.GetResult(ManagerLevel.Head, request2);
            #endregion

            #region Ver 2
            //var manager1 = new Manager("Adam");
            //var manager2 = new Director("Martin");
            //var manager3 = new Head("Declan");
            //manager1.Superior = manager2;
            //manager2.Superior = manager3;

            //var request1 = new Request
            //{
            //    Quantity = 1000,
            //    RequestType = RequestType.SalaryIncrease,
            //    RequestContent = "Karl asks salary increase."
            //};

            //manager1.RequestApplications(request1);

            //var manager4 = new Manager("Adam");
            //var manager5 = new Director("Martin");
            //var manager6 = new Head("Declan");
            //manager4.Superior = manager5;
            //manager5.Superior = manager6;

            //var request2 = new Request
            //{
            //    Quantity = 3,
            //    RequestType = RequestType.Leave,
            //    RequestContent = "Beck asks for leave."
            //};

            //manager4.RequestApplications(request2);
            #endregion
        }
    }
}
