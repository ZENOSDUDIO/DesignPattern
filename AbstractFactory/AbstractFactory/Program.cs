using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            var user = new User();
            var su = new SqlServerUser();
            su.Insert(user);
            su.GetUser(1);
            #endregion

            #region Ver 2
            //var user = new User();
            //IFactory factory = new SqlServerFactory();
            //IUser ui = factory.CreateUser();
            //ui.Insert(user);
            //ui.GetUser(1);
            #endregion

            #region Ver 3
            //var user = new User();
            //IFactory factory = new SqlServerFactory();
            //IUser ui = factory.CreateUser();
            //ui.Insert(user);
            //ui.GetUser(1);

            //var dept = new Department();
            //IDepartment id = factory.CreateDepartment();
            //id.Insert(dept);
            //id.GetDepartment(1);
            #endregion

            #region Ver 4
            //var user = new User();
            //IUser ui = DataAccess.CreateUser();
            //ui.Insert(user);
            //ui.GetUser(1);
            #endregion
        }
    }
}
