using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    #region Ver 1
    public class HandsetGame
    {
        public virtual void Run() { }
    }

    public class HandsetMGame : HandsetGame
    {
        public override void Run()
        {
            Console.WriteLine("Run the game on handset M.");
        }
    }

    public class HandsetNGame : HandsetGame
    {
        public override void Run()
        {
            Console.WriteLine("Run the game on handset N.");
        }
    }
    #endregion

    #region Ver 2
    //public class HandsetBrand
    //{
    //    public virtual void Run() { }
    //}

    //public class HandsetBrandM : HandsetBrand { }

    //public class HandsetBrandN : HandsetBrand { }

    //public class HandsetBrandMGame : HandsetBrandM
    //{
    //    public override void Run()
    //    {
    //        Console.WriteLine("Run the game on handset M.");
    //    }
    //}

    //public class HandsetBrandNGame : HandsetBrandN
    //{
    //    public override void Run()
    //    {
    //        Console.WriteLine("Run the game on handset N.");
    //    }
    //}

    //public class HandsetBrandMContactList : HandsetBrandM
    //{
    //    public override void Run()
    //    {
    //        Console.WriteLine("Contact list of handset M.");
    //    }
    //}

    //public class HandsetBrandNContactList : HandsetBrandM
    //{
    //    public override void Run()
    //    {
    //        Console.WriteLine("Contact list of handset N.");
    //    }
    //}
    #endregion

    #region Ver 3
    //public abstract class HandsetSoft
    //{
    //    public abstract void Run();
    //}

    //public class HandsetGame : HandsetSoft
    //{
    //    public override void Run()
    //    {
    //        Console.WriteLine("Run game on handset");
    //    }
    //}

    //public class HandsetContactList : HandsetSoft
    //{
    //    public override void Run()
    //    {
    //        Console.WriteLine("Contact list on handset");
    //    }
    //}

    //public abstract class HandsetBrand
    //{
    //    protected HandsetSoft Soft;

    //    public void SetHandsetSoft(HandsetSoft soft)
    //    {
    //        Soft = soft;
    //    }

    //    public abstract void Run();
    //}

    //public class HandsetBrandM : HandsetBrand
    //{
    //    public override void Run()
    //    {
    //        Soft.Run();
    //    }
    //}

    //public class HandsetBrandN : HandsetBrand
    //{
    //    public override void Run()
    //    {
    //        Soft.Run();
    //    }
    //}
    #endregion
}
