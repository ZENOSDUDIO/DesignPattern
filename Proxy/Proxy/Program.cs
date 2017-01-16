using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            var nacy = new SchoolGirl();
            nacy.Name = "Nacy";

            var adam = new Pursuer(nacy);
            adam.GiveDolls();
            adam.GiveFlowers();
            adam.GiveChocolate();
            #endregion

            #region Ver 2
            //var nacy = new SchoolGirl();
            //nacy.Name = "Nacy";

            //var proxy = new Proxy(nacy);
            //proxy.GiveDolls();
            //proxy.GiveFlowers();
            //proxy.GiveChocolate();
            #endregion

            #region Ver 3
            //var nacy = new SchoolGirl();
            //nacy.Name = "Nacy";

            //var proxy = new Proxy(nacy);
            //proxy.GiveDolls();
            //proxy.GiveFlowers();
            //proxy.GiveChocolate();
            #endregion
        }
    }
}
