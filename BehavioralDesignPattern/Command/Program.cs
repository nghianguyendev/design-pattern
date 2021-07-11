using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Command Design Pattern!");

            var airConditioner = new AirConditioner();
            var oncommand = new OnCommand(airConditioner);
            var remoteInvoker = new RemoteInvoker(oncommand);

            remoteInvoker.PressButton();

            var offcommand = new OffCommand(airConditioner);
            remoteInvoker.SetCommand(offcommand);
            remoteInvoker.PressButton();
        }
    }
}
