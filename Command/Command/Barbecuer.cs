using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    #region Ver 1
    public class Barbecuer
    {
        public void BakeMutton()
        {
            Console.WriteLine("Bake mutton");
        }

        public void BakeChickenWing()
        {
            Console.WriteLine("Bake chicken wing");
        }
    }
    #endregion

    #region Ver 2 : Ver 1
    //public abstract class Command
    //{
    //    protected Barbecuer Receiver;

    //    public Command(Barbecuer receiver)
    //    {
    //        Receiver = receiver;
    //    }

    //    public abstract void ExecuteCommand();
    //}

    //public class BakeMuttonCommand : Command
    //{
    //    public BakeMuttonCommand(Barbecuer receiver) : base(receiver) { }

    //    public override void ExecuteCommand()
    //    {
    //        Receiver.BakeMutton();
    //    }
    //}

    //public class BakeChickenWingCommand : Command
    //{
    //    public BakeChickenWingCommand(Barbecuer receiver) : base(receiver) { }

    //    public override void ExecuteCommand()
    //    {
    //        Receiver.BakeChickenWing();
    //    }
    //}

    //public class Waiter
    //{
    //    private Command command;

    //    public void SetOrder(Command command)
    //    {
    //        this.command = command;
    //    }

    //    public void Notify()
    //    {
    //        command.ExecuteCommand();
    //    }
    //}
    #endregion

    #region Ver 3 : Ver 2
    //public class Waiter
    //{
    //    private IList<Command> orders = new List<Command>();

    //    public void SetOrder(Command command)
    //    {
    //        if (command is BakeChickenWingCommand)
    //        {
    //            Console.WriteLine("Waiter: Out of wings");
    //        }
    //        else
    //        {
    //            orders.Add(command);
    //            Console.WriteLine("Order added: {0}. Time: {1}.", command.ToString(), DateTime.Now.ToString());
    //        }
    //    }

    //    public void CancelOrder(Command command)
    //    {
    //        orders.Remove(command);
    //        Console.WriteLine("Order canceled: {0}. Time: {1}.", command.ToString(), DateTime.Now.ToString());
    //    }

    //    public void Notify()
    //    {
    //        foreach (var order in orders)
    //        {
    //            order.ExecuteCommand();
    //        }
    //    }
    //}
    #endregion
}
