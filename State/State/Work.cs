using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    #region Ver 2
    //public class Work
    //{
    //    public int Hour { get; set; }
    //    public bool TaskFinished { get; set; }

    //    public void WriteProgram()
    //    {
    //        if (Hour < 12)
    //        {
    //            Console.WriteLine("Now time: {0}. Working in morning. Feels good.", Hour);
    //        }
    //        else if (Hour < 13)
    //        {
    //            Console.WriteLine("Now time: {0}. Lunch time.", Hour);
    //        }
    //        else if (Hour < 17)
    //        {
    //            Console.WriteLine("Now time: {0}. Working at afternoon.", Hour);
    //        }
    //        else
    //        {
    //            if (TaskFinished)
    //            {
    //                Console.WriteLine("Now time: {0}. Back home.", Hour);
    //            }
    //            else
    //            {
    //                if (Hour < 21)
    //                {
    //                    Console.WriteLine("Now time: {0}. Overtime, tried.", Hour);
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Now time: {0}. Have to go to sleep.", Hour);
    //                }
    //            }
    //        }
    //    }
    //}
    #endregion

    #region Ver 3
    //public class Work
    //{
    //    public int Hour { get; set; }
    //    public bool TaskFinished { get; set; }
    //    private State current;

    //    public Work()
    //    {
    //        current = new MorningState();
    //    }

    //    public void SetState(State s)
    //    {
    //        current = s;
    //    }

    //    public void WriteProgram()
    //    {
    //        current.WriteProgram(this);
    //    }
    //}
    #endregion
}
