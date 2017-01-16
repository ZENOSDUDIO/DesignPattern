using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    #region Ver 1
    public class Resume
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company;

        public Resume(string name)
        {
            this.name = name;
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("Working Experience: {0} {1}", timeArea, company);
        }
    }
    #endregion

    #region Ver 2
    //public class Resume : ICloneable
    //{
    //    private string name;
    //    private string sex;
    //    private string age;
    //    private string timeArea;
    //    private string company;

    //    public Resume(string name)
    //    {
    //        this.name = name;
    //    }

    //    public void SetPersonalInfo(string sex, string age)
    //    {
    //        this.sex = sex;
    //        this.age = age;
    //    }

    //    public void SetWorkExperience(string timeArea, string company)
    //    {
    //        this.timeArea = timeArea;
    //        this.company = company;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine("{0} {1} {2}", name, sex, age);
    //        Console.WriteLine("Working Experience: {0} {1}", timeArea, company);
    //    }

    //    public object Clone()
    //    {
    //        return (object)MemberwiseClone();
    //    }
    //}
    #endregion

    #region Ver 3
    //public class Resume : ICloneable
    //{
    //    private string name;
    //    private string sex;
    //    private string age;
    //    private WorkExperience work;

    //    public Resume(string name)
    //    {
    //        this.name = name;
    //        work = new WorkExperience();
    //    }

    //    public void SetPersonalInfo(string sex, string age)
    //    {
    //        this.sex = sex;
    //        this.age = age;
    //    }

    //    public void SetWorkExperience(string workDate, string company)
    //    {
    //        work.WorkDate = workDate;
    //        work.Company = company;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine("{0} {1} {2}", name, sex, age);
    //        Console.WriteLine("Working Experience: {0} {1}", work.WorkDate, work.Company);
    //    }

    //    public object Clone()
    //    {
    //        return (object)MemberwiseClone();
    //    }
    //}
    #endregion

    #region Ver 4
    //public class Resume : ICloneable
    //{
    //    private string name;
    //    private string sex;
    //    private string age;
    //    private WorkExperience work;

    //    public Resume(string name)
    //    {
    //        this.name = name;
    //        work = new WorkExperience();
    //    }

    //    public Resume(WorkExperience work)
    //    {
    //        this.work = (WorkExperience)work.Clone();
    //    }

    //    public void SetPersonalInfo(string sex, string age)
    //    {
    //        this.sex = sex;
    //        this.age = age;
    //    }

    //    public void SetWorkExperience(string workDate, string company)
    //    {
    //        work.WorkDate = workDate;
    //        work.Company = company;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine("{0} {1} {2}", name, sex, age);
    //        Console.WriteLine("Working Experience: {0} {1}", work.WorkDate, work.Company);
    //    }

    //    public object Clone()
    //    {
    //        var obj = new Resume(work);
    //        obj.name = name;
    //        obj.sex = sex;
    //        obj.age = age;

    //        return obj;
    //    }
    //}
    #endregion
}
