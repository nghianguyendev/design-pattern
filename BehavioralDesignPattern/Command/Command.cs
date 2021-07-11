using System;

namespace Command
{
    internal class AirConditioner
    {
        public void On()
        {
            Console.WriteLine("On");
        }

        public void Off()
        {
            Console.WriteLine("Off");
        }
    }

    internal abstract class Command
    {
        protected AirConditioner _airConditioner;

        public Command(AirConditioner airConditioner)
        {
            this._airConditioner = airConditioner;
        }

        public abstract void Execute();
    }

    internal class OnCommand : Command
    {
        public OnCommand(AirConditioner airConditioner) : base(airConditioner)
        {
        }

        public override void Execute()
        {
            _airConditioner.On();
        }
    }

    internal class OffCommand : Command
    {
        public OffCommand(AirConditioner airConditioner) : base(airConditioner)
        {
        }

        public override void Execute()
        {
            _airConditioner.Off();
        }
    }

    internal class RemoteInvoker
    {
        private Command _command;

        public RemoteInvoker(Command command)
        {
            _command = command;
        }

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}