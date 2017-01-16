using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsibilityChain
{
    public enum ManagerLevel
    {
        Manager,
        Director,
        Head
    }

    public enum RequestType
    {
        Leave,
        SalaryIncrease
    }

    #region Ver 1
    public class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public void GetResult(ManagerLevel managerLevel, Request request)
        {
            if (managerLevel == ManagerLevel.Manager)
            {
                if (request.RequestType == RequestType.Leave && request.Quantity <= 2)
                {
                    Console.WriteLine("{0}:{1} Quantity {2} has been approved.",
                        Name, request.RequestContent, request.Quantity);
                }
                else
                {
                    Console.WriteLine("{0}:{1} Quantity {2}. I don't have such authority.",
                        Name, request.RequestContent, request.Quantity);
                }
            }
            else if (managerLevel == ManagerLevel.Director)
            {
                if (request.RequestType == RequestType.Leave && request.Quantity <= 5)
                {
                    Console.WriteLine("{0}:{1} Quantity {2} has been approved.",
                        Name, request.RequestContent, request.Quantity);
                }
                else
                {
                    Console.WriteLine("{0}:{1} Quantity {2}. I don't have such authority.",
                        Name, request.RequestContent, request.Quantity);
                }
            }
            else if (managerLevel == ManagerLevel.Head)
            {
                if (request.RequestType == RequestType.Leave)
                {
                    Console.WriteLine("{0}:{1} Quantity {2} has been approved.",
                        Name, request.RequestContent, request.Quantity);
                }
                else if (request.RequestType == RequestType.SalaryIncrease && request.Quantity <= 500)
                {
                    Console.WriteLine("{0}:{1} Quantity {2} has been approved.",
                        Name, request.RequestContent, request.Quantity);
                }
                else if (request.RequestType == RequestType.SalaryIncrease && request.Quantity > 500)
                {
                    Console.WriteLine("{0}:{1} Quantity {2}. Forget about this!",
                        Name, request.RequestContent, request.Quantity);
                }
            }
        }
    }
    #endregion

    #region Ver 2
    //public abstract class ManagerBase
    //{
    //    public string Name { get; set; }
    //    public ManagerBase Superior { get; set; }

    //    public ManagerBase(string name)
    //    {
    //        Name = name;
    //    }

    //    public abstract void RequestApplications(Request request);
    //}

    //public class Manager : ManagerBase
    //{
    //    public Manager(string name) : base(name) { }

    //    public override void RequestApplications(Request request)
    //    {
    //        if (request.RequestType == RequestType.Leave && request.Quantity <= 2)
    //        {
    //            Console.WriteLine("{0}:{1} Quantity {2} has been approved.", 
    //                Name, request.RequestContent, request.Quantity);
    //        }
    //        else
    //        {
    //            if (Superior != null)
    //            {
    //                Superior.RequestApplications(request);
    //            }
    //        }
    //    }
    //}

    //public class Director : ManagerBase
    //{
    //    public Director(string name) : base(name) { }

    //    public override void RequestApplications(Request request)
    //    {
    //        if (request.RequestType == RequestType.Leave && request.Quantity <= 5)
    //        {
    //            Console.WriteLine("{0}:{1} Quantity {2} has been approved.", Name, request.RequestContent, request.Quantity);
    //        }
    //        else
    //        {
    //            if (Superior != null)
    //            {
    //                Superior.RequestApplications(request);
    //            }
    //        }
    //    }
    //}

    //public class Head : ManagerBase
    //{
    //    public Head(string name) : base(name) { }

    //    public override void RequestApplications(Request request)
    //    {
    //        if (request.RequestType == RequestType.Leave)
    //        {
    //            Console.WriteLine("{0}:{1} Quantity {2} has been approved.", Name, request.RequestContent, request.Quantity);
    //        }
    //        else if (request.RequestType == RequestType.SalaryIncrease && request.Quantity <= 500)
    //        {
    //            Console.WriteLine("{0}:{1} Quantity {2} has been approved.", Name, request.RequestContent, request.Quantity);
    //        }
    //        else if (request.RequestType == RequestType.SalaryIncrease && request.Quantity > 500)
    //        {
    //            Console.WriteLine("{0}:{1} Quantity {2}. Forget about this!", Name, request.RequestContent, request.Quantity);
    //        }
    //    }
    //}
    #endregion
}
