using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            var resume1 = new Resume("Adam");
            resume1.SetPersonalInfo("Male", "29");
            resume1.SetWorkExperience("1998-2000", "HP");

            var resume2 = new Resume("Scott");
            resume2.SetPersonalInfo("Male", "29");
            resume2.SetWorkExperience("1998-2000", "Microsoft");

            var resume3 = new Resume("Jason");
            resume3.SetPersonalInfo("Male", "29");
            resume3.SetWorkExperience("1998-2000", "EMC");

            resume1.Display();
            resume2.Display();
            resume3.Display();
            #endregion

            #region Ver 2 & 3 & 4
            //var resume1 = new Resume("Adam");
            //resume1.SetPersonalInfo("Male", "29");
            //resume1.SetWorkExperience("1998-2000", "HP");

            //var resume2 = (Resume)resume1.Clone();
            //resume2.SetWorkExperience("1998-2000", "Microsoft");

            //var resume3 = (Resume)resume1.Clone(); ;
            //resume3.SetPersonalInfo("Male", "24");

            //resume1.Display();
            //resume2.Display();
            //resume3.Display();
            #endregion
        }
    }
}
