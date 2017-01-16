using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    #region Ver 3
    //public abstract class State
    //{
    //    public abstract void WriteProgram(Work work);
    //}

    //public class MorningState : State
    //{
    //    public override void WriteProgram(Work work)
    //    {
    //        if (work.Hour < 12)
    //        {
    //            Console.WriteLine("Now time: {0}. Working in morning. Feels good.", work.Hour);
    //        }
    //        else
    //        {
    //            work.SetState(new NoonState());
    //            work.WriteProgram();
    //        }
    //    }
    //}

    //public class NoonState : State
    //{
    //    public override void WriteProgram(Work work)
    //    {
    //        if (work.Hour < 13)
    //        {
    //            Console.WriteLine("Now time: {0}. Lunch time.", work.Hour);
    //        }
    //        else
    //        {
    //            work.SetState(new AfternoonState());
    //            work.WriteProgram();
    //        }
    //    }
    //}

    //public class AfternoonState : State
    //{
    //    public override void WriteProgram(Work work)
    //    {
    //        if (work.Hour < 17)
    //        {
    //            Console.WriteLine("Now time: {0}. Working at afternoon.", work.Hour);
    //        }
    //        else
    //        {
    //            work.SetState(new EveningState());
    //            work.WriteProgram();
    //        }
    //    }
    //}

    //public class EveningState : State
    //{
    //    public override void WriteProgram(Work work)
    //    {
    //        if (work.TaskFinished)
    //        {
    //            work.SetState(new RestState());
    //            work.WriteProgram();
    //        }
    //        else
    //        {
    //            if (work.Hour < 21)
    //            {
    //                Console.WriteLine("Now time: {0}. Overtime, tried.", work.Hour);
    //            }
    //            else
    //            {
    //                work.SetState(new SleepingState());
    //                work.WriteProgram();
    //            }
    //        }
    //    }
    //}

    //public class SleepingState : State
    //{
    //    public override void WriteProgram(Work work)
    //    {
    //        Console.WriteLine("Now time: {0}. Have to go to sleep.", work.Hour);
    //    }
    //}

    //public class RestState : State
    //{
    //    public override void WriteProgram(Work work)
    //    {
    //        Console.WriteLine("Now time: {0}. Back home.", work.Hour);
    //    }
    //}
    #endregion

    #region State
    //public abstract class State
    //{
    //    public abstract void Handle(Context context);
    //}

    //public class ConcreteStateA : State
    //{
    //    public override void Handle(Context context)
    //    {
    //        context.State = new ConcreteStateB();
    //    }
    //}

    //public class ConcreteStateB : State
    //{
    //    public override void Handle(Context context)
    //    {
    //        context.State = new ConcreteStateA();
    //    }
    //}

    //public class Context
    //{
    //    private State state;

    //    public Context(State state)
    //    {
    //        this.state = state;
    //    }

    //    public State State
    //    {
    //        get
    //        {
    //            return state;
    //        }
    //        set
    //        {
    //            state = value;
    //            Console.WriteLine("Current state: {0}", state.GetType().Name);
    //        }
    //    }

    //    public void Request()
    //    {
    //        state.Handle(this);
    //    }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        var c = new Context(new ConcreteStateA());
    //        c.Request();
    //        c.Request();
    //        c.Request();
    //        c.Request();
    //    }
    //}
    #endregion
}
