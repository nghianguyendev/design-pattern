using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Null Object Design Pattern!");

            var log = Null<ILog>.Instance;
            //var log = new ConsoleLog();
            var ba = new BankAccount(log);
            ba.Deposit(100);
            ba.Withdraw(200);
        }
    }
}
