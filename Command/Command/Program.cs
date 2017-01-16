using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            var boy = new Barbecuer();
            boy.BakeMutton();
            boy.BakeChickenWing();
            #endregion

            #region Ver 2
            //var boy = new Barbecuer();
            //var bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            //var bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            //var bakeChickenWingCommand1 = new BakeChickenWingCommand(boy);

            //var girl = new Waiter();
            //girl.SetOrder(bakeMuttonCommand1);
            //girl.Notify();

            //girl.SetOrder(bakeMuttonCommand2);
            //girl.Notify();

            //girl.SetOrder(bakeChickenWingCommand1);
            //girl.Notify();
            #endregion

            #region Ver 3
            //var boy = new Barbecuer();
            //var bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            //var bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            //var bakeChickenWingCommand1 = new BakeChickenWingCommand(boy);

            //var girl = new Waiter();
            //girl.SetOrder(bakeMuttonCommand1);
            //girl.SetOrder(bakeMuttonCommand2);
            //girl.SetOrder(bakeChickenWingCommand1);

            //girl.Notify();
            #endregion
        }
    }
}
