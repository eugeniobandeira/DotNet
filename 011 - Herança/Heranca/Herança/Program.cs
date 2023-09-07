using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(2145, "Jorge White", 500.00);
            BusinessAccount bacc = new BusinessAccount(1010, "Maria Maura", 0.00, 500.00);

            //Upcasting
            Account acc1 = bacc; //bacc é um account
            Account acc2 = new BusinessAccount(4531, "Wayne Jr", 7412.54, 1000.00);
            Account acc3 = new SavingsAccount(1010, "Georgia Lai", 100.15, 0.1);

            //Downcasting
            //BusinessAccount acc4 = acc2; apresenta erro de conversão
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00); //Somente o business account tem a operação loan

            //BusinessAccount acc5 = (BusinessAccount)acc3; resulta em erro
            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = acc3 as BusinessAccount; É outra forma de fazer conversão
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(214.99);
                Console.WriteLine("Loan!");
            }
            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = acc3 as SavingsAccount;
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}