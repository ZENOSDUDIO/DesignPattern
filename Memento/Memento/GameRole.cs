using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    #region Ver 1
    public class GameRole
    {
        public int Life { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public void StateDisplay()
        {
            Console.WriteLine("Role's current state:");
            Console.WriteLine("Life: {0}", Life);
            Console.WriteLine("Attack: {0}", Attack);
            Console.WriteLine("Defense: {0}", Defense);
        }

        public void GetInitState()
        {
            Life = 100;
            Attack = 100;
            Defense = 100;
        }

        public void Fight()
        {
            Life = 0;
            Attack = 0;
            Defense = 0;
        }

        #region Ver 2
        //public RoleStateMemento SaveState()
        //{
        //    return (new RoleStateMemento(Life, Attack, Defense));
        //}

        //public void RecoveryState(RoleStateMemento memento)
        //{
        //    Life = memento.Life;
        //    Attack = memento.Attack;
        //    Defense = memento.Defense;
        //}
        #endregion
    }
    #endregion

    #region Ver 2
    //public class RoleStateMemento
    //{
    //    public int Life { get; set; }
    //    public int Attack { get; set; }
    //    public int Defense { get; set; }

    //    public RoleStateMemento(int life, int attack, int defense)
    //    {
    //        Life = life;
    //        Attack = attack;
    //        Defense = defense;
    //    }
    //}

    //public class RoleStateCaretaker
    //{
    //    public RoleStateMemento RoleStateMemento { get; set; }
    //}
    #endregion
}
