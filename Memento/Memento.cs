namespace Memento
{
    internal class Memento
    {
        public double Balance { get; set; }

        public Memento(double balance)
        {
            this.Balance = balance;
        }
    }

    internal class CareTaker
    {
        public Memento CheckPoint { get; set; }
    }

    internal class BankAccount
    {
        private double balance;

        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public Memento Deposit(double amount)
        {
            this.balance += amount;
            return new Memento(balance);
        }

        public void Restore(Memento memento)
        {
            this.balance = memento.Balance;
        }

        public override string ToString()
        {
            return $"{nameof(balance)} : {balance}";
        }
    }
}