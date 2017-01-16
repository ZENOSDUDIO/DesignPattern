using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AbstractFactory
{
    #region Ver 1
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class SqlServerUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("Insert a new row into user table in SQL Server database.");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("Get a row from user table in SQL Server database by id.");
            return null;
        }
    }
    #endregion

    #region Ver 2
    //public interface IUser
    //{
    //    void Insert(User user);
    //    User GetUser(int id);
    //}

    //public class User
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //}

    //public class SqlServerUser : IUser
    //{
    //    public void Insert(User user)
    //    {
    //        Console.WriteLine("Insert a new row into user table in SQL Server database.");
    //    }

    //    public User GetUser(int id)
    //    {
    //        Console.WriteLine("Get a row from user table in SQL Server database by id.");
    //        return null;
    //    }
    //}

    //public class AccessUser : IUser
    //{
    //    public void Insert(User user)
    //    {
    //        Console.WriteLine("Insert a new row into user table in Access database.");
    //    }

    //    public User GetUser(int id)
    //    {
    //        Console.WriteLine("Get a row from user table in Access database by id.");
    //        return null;
    //    }
    //}

    //public interface IFactory
    //{
    //    IUser CreateUser();
    //}

    //public class SqlServerFactory : IFactory
    //{
    //    public IUser CreateUser()
    //    {
    //        return new SqlServerUser();
    //    }
    //}

    //public class AccessFactory : IFactory
    //{
    //    public IUser CreateUser()
    //    {
    //        return new AccessUser();
    //    }
    //}
    #endregion

    #region Ver 3
    //public interface IUser
    //{
    //    void Insert(User user);
    //    User GetUser(int id);
    //}

    //public class User
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //}

    //public class SqlServerUser : IUser
    //{
    //    public void Insert(User user)
    //    {
    //        Console.WriteLine("Insert a new row into user table in SQL Server database.");
    //    }

    //    public User GetUser(int id)
    //    {
    //        Console.WriteLine("Get a row from user table in SQL Server database by id.");
    //        return null;
    //    }
    //}

    //public class AccessUser : IUser
    //{
    //    public void Insert(User user)
    //    {
    //        Console.WriteLine("Insert a new row into user table in Access database.");
    //    }

    //    public User GetUser(int id)
    //    {
    //        Console.WriteLine("Get a row from user table in Access database by id.");
    //        return null;
    //    }
    //}

    //public class Department
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //}

    //public interface IDepartment
    //{
    //    void Insert(Department department);
    //    Department GetDepartment(int id);
    //}

    //public class SqlServerDepartment : IDepartment
    //{
    //    public void Insert(Department department)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Department GetDepartment(int id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class AccessDepartment : IDepartment
    //{
    //    public void Insert(Department department)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Department GetDepartment(int id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public interface IFactory
    //{
    //    IUser CreateUser();
    //    IDepartment CreateDepartment();
    //}

    //public class SqlServerFactory : IFactory
    //{
    //    public IUser CreateUser()
    //    {
    //        return new SqlServerUser();
    //    }

    //    public IDepartment CreateDepartment()
    //    {
    //        return new SqlServerDepartment();
    //    }
    //}

    //public class AccessFactory : IFactory
    //{
    //    public IUser CreateUser()
    //    {
    //        return new AccessUser();
    //    }

    //    public IDepartment CreateDepartment()
    //    {
    //        return new AccessDepartment();
    //    }
    //}
    #endregion

    #region Ver 4 : Ver 3
    //public class DataAccess
    //{
    //    private static readonly string db = "SqlServer";
    //    //private static readonly string db = "Access";

    //    public static IUser CreateUser()
    //    {
    //        IUser result = null;

    //        switch (db)
    //        {
    //            case "SqlServer":
    //                result = new SqlServerUser();
    //                break;
    //            case "Access":
    //                result = new AccessUser();
    //                break;
    //            default:
    //                break;
    //        }

    //        return result;
    //    }
    //}
    #endregion

    #region Ver 5 : Ver 3
    //public class DataAccess
    //{
    //    private static readonly string assemblyName = "AbstractFactory";
    //    private static readonly string db = "SqlServer";
    //    //private static readonly string db = "Access";

    //    public static IUser CreateUser()
    //    {
    //        string className = string.Format("{0}.{1}User", assemblyName, db);

    //        return (IUser)Assembly.Load(assemblyName).CreateInstance(className);
    //    }
    //}
    #endregion
}
