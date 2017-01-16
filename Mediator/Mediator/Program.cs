using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsc = new UnitedNationsSeccurityCouncil();
            var c1 = new USA(unsc);
            var c2 = new Iraq(unsc);

            unsc.SetColleague1(c1);
            unsc.SetColleague2(c2);

            c1.Declare("No nuclear weapon!");
            c2.Declare("We don't have one!");
        }
    }
}
