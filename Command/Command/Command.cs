using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    #region Command
    //public abstract class Command
    //{
    //    protected Receiver Receiver;

    //    public Command(Receiver receiver)
    //    {
    //        Receiver = receiver;
    //    }

    //    public abstract void Execute();
    //}

    //public class ConcreteCommand : Command
    //{
    //    public ConcreteCommand(Receiver receiver) : base(receiver) { }

    //    public override void Execute()
    //    {
    //        Receiver.Action();
    //    }
    //}

    //public class Invoker
    //{
    //    private Command command;

    //    public void SetCommand(Command command)
    //    {
    //        this.command = command;
    //    }

    //    public void ExecuteCommand()
    //    {
    //        command.Execute();
    //    }
    //}

    //public class Receiver
    //{
    //    public void Action()
    //    {
    //        Console.WriteLine("Execute the requested command.");
    //    }
    //}

    //public class Client
    //{
    //    public void DoWork()
    //    {
    //        var receiver = new Receiver();
    //        Command command = new ConcreteCommand(receiver);
    //        var invoker = new Invoker();
    //        invoker.SetCommand(command);
    //        invoker.ExecuteCommand();
    //    }
    //}
    #endregion
}
