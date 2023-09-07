

namespace Course.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //Protected deixa a sub classe "modificar" o saldo, o programa principal não consegue.

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
