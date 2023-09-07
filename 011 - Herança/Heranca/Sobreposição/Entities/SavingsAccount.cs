

namespace Course.Entities
{
   /* sealed */class SavingsAccount : Account
    {
        
        public double InterestRate { get; set; }
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Esse override vai sobrescrever a operação withdraw da classe Account
        public /* sealed */ override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.00;
        }
        //É uma boa prática selar operações que já foram sobrescritas
    }
}
