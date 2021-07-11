using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Memento Design Pattern!");

            var bankAccount = new BankAccount(100);
            Console.WriteLine(bankAccount.ToString());

            var careTaker = new CareTaker();
            careTaker.CheckPoint = bankAccount.Deposit(100);
            Console.WriteLine($"First deposit: {bankAccount.ToString()}");

            var savePoint2 = bankAccount.Deposit(100);
            Console.WriteLine($"Second deposit: {bankAccount.ToString()}");

            Console.WriteLine("Restore to First deposit");
            bankAccount.Restore(careTaker.CheckPoint);
            Console.WriteLine(bankAccount.ToString());
            Console.ReadKey();

        }
    }
}
