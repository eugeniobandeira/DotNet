using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Account acc1 = new Account(1015, "Eugenio B", 100.15);
            Account acc2 = new SavingsAccount(1452, "Di", 100.15, 0.01);

            acc1.Withdraw(10.00);
            acc2.Withdraw(10.00);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}