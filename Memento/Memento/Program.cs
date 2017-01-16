using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            var player = new GameRole();
            player.GetInitState();
            player.StateDisplay();

            //Save the state
            var backup = new GameRole();
            backup.Life = player.Life;
            backup.Attack = player.Attack;
            backup.Defense = player.Defense;

            player.Fight();
            player.StateDisplay();

            player.Life = backup.Life;
            player.Attack = backup.Attack;
            player.Defense = backup.Defense;
            player.StateDisplay();
            #endregion

            #region Ver 2
            //var player = new GameRole();
            //player.GetInitState();
            //player.StateDisplay();

            ////Save the state
            //var stateAdmin = new RoleStateCaretaker();
            //stateAdmin.RoleStateMemento = player.SaveState();

            //player.Fight();
            //player.StateDisplay();

            //player.RecoveryState(stateAdmin.RoleStateMemento);
            //player.StateDisplay();
            #endregion
        }
    }
}
