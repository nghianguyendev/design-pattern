using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strategy design pattern!");

            var logService = new LogService();
            logService.Log(LogType.Console, "Console message");
            logService.Log(LogType.File, "File message");

            Console.ReadKey();
        }
    }
}
