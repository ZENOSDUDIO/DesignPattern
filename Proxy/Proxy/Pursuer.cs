using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    #region Ver 1
    public class Pursuer
    {
        private SchoolGirl mm;

        public Pursuer(SchoolGirl mm)
        {
            this.mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine(string.Format("{0}, give you the dolls.", mm.Name));
        }

        public void GiveFlowers()
        {
            Console.WriteLine(string.Format("{0}, give you the flowers.", mm.Name));
        }

        public void GiveChocolate()
        {
            Console.WriteLine(string.Format("{0}, give you the chocolate.", mm.Name));
        }
    }
    #endregion

    #region Ver 3
    //public class Pursuer : IGiveGift
    //{
    //    private SchoolGirl mm;

    //    public Pursuer(SchoolGirl mm)
    //    {
    //        this.mm = mm;
    //    }

    //    public void GiveDolls()
    //    {
    //        Console.WriteLine(string.Format("{0}, give you the dolls.", mm.Name));
    //    }

    //    public void GiveFlowers()
    //    {
    //        Console.WriteLine(string.Format("{0}, give you the flowers.", mm.Name));
    //    }

    //    public void GiveChocolate()
    //    {
    //        Console.WriteLine(string.Format("{0}, give you the chocolate.", mm.Name));
    //    }
    //}
    #endregion
}
