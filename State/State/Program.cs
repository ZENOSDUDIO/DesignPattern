using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            Hour = 9;
            WriteProgram();
            Hour = 10;
            WriteProgram();
            Hour = 12;
            WriteProgram();
            Hour = 13;
            WriteProgram();
            Hour = 14;
            WriteProgram();
            Hour = 17;

            TaskFinished = false;

            WriteProgram();
            Hour = 19;
            WriteProgram();
            Hour = 22;
            WriteProgram();
            #endregion

            #region Ver 2 & Ver 3
            //var work = new Work();
            //work.Hour = 9;
            //work.WriteProgram();
            //work.Hour = 10;
            //work.WriteProgram();
            //work.Hour = 12;
            //work.WriteProgram();
            //work.Hour = 13;
            //work.WriteProgram();
            //work.Hour = 14;
            //work.WriteProgram();
            //work.Hour = 17;

            //work.TaskFinished = false;

            //work.WriteProgram();
            //work.Hour = 19;
            //work.WriteProgram();
            //work.Hour = 22;
            //work.WriteProgram();
            #endregion
        }

        #region Ver 1
        static int Hour = 0;
        static bool TaskFinished = false;

        public static void WriteProgram()
        {
            if (Hour < 12)
            {
                Console.WriteLine("Now time: {0}. Working in morning. Feels good.", Hour);
            }
            else if (Hour < 13)
            {
                Console.WriteLine("Now time: {0}. Lunch time.", Hour);
            }
            else if (Hour < 17)
            {
                Console.WriteLine("Now time: {0}. Working at afternoon.", Hour);
            }
            else
            {
                if (TaskFinished)
                {
                    Console.WriteLine("Now time: {0}. Back home.", Hour);
                }
                else
                {
                    if (Hour < 21)
                    {
                        Console.WriteLine("Now time: {0}. Overtime, tried.", Hour);
                    }
                    else
                    {
                        Console.WriteLine("Now time: {0}. Have to go to sleep.", Hour);
                    }
                }
            }
        }
        #endregion
    }
}
