using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            var secretary = new Secretary();
            var observer1 = new StockObserver("Kevin", secretary);
            var observer2 = new StockObserver("Carol", secretary);

            secretary.Attach(observer1);
            secretary.Attach(observer2);

            secretary.SecretaryAction = "Boss is coming";
            secretary.Notify();
            #endregion

            #region Ver 2
            //var secretary = new Secretary();
            //var observer1 = new StockObserver("Kevin", secretary);
            //var observer2 = new NBAObserver("Carol", secretary);

            //secretary.Attach(observer1);
            //secretary.Attach(observer2);

            //secretary.SecretaryAction = "Boss is coming";
            //secretary.Notify();
            #endregion

            #region Ver 3
            //var boss = new Boss();
            //var observer1 = new StockObserver("Kevin", boss);
            //var observer2 = new NBAObserver("Carol", boss);

            //boss.Attach(observer1);
            //boss.Attach(observer2);

            //boss.SubjectState = "I am coming!";
            //boss.Notify();
            #endregion

            #region Ver 4
            //var boss = new Boss();
            //var observer1 = new StockObserver("Kevin", boss);
            //var observer2 = new NBAObserver("Carol", boss);

            //boss.Update += new EventHandler(observer1.CloseBrowser);
            //boss.Update += new EventHandler(observer2.ShutdownPlayer);

            //boss.SubjectState = "I am coming!";
            //boss.Notify();
            #endregion
        }
    }
}
