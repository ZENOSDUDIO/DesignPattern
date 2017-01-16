using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    #region Ver 1
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
    #endregion

    #region Ver 2
    //public class Singleton
    //{
    //    private static Singleton instance;
    //    private static readonly object syncRoot = new object();

    //    private Singleton() { }

    //    public static Singleton GetInstance()
    //    {
    //        lock (syncRoot)
    //        {
    //            if (instance == null)
    //            {
    //                instance = new Singleton();
    //            }
    //        }

    //        return instance;
    //    }
    //}
    #endregion

    #region Ver 3
    //public class Singleton
    //{
    //    private static Singleton instance;
    //    private static readonly object syncRoot = new object();

    //    private Singleton() { }

    //    public static Singleton GetInstance()
    //    {
    //        if (instance == null)
    //        {
    //            lock (syncRoot)
    //            {
    //                if (instance == null)
    //                {
    //                    instance = new Singleton();
    //                }
    //            }
    //        }

    //        return instance;
    //    }
    //}
    #endregion

    #region Ver 4
    //public class Singleton
    //{
    //    private static readonly Singleton instance = new Singleton();

    //    private Singleton() { }

    //    public static Singleton GetInstance()
    //    {
    //        return instance;
    //    }
    //}
    #endregion
}
