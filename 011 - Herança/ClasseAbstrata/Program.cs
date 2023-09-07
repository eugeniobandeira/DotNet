﻿using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();
            
            list.Add(new SavingsAccount(1001, "Cristiano", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Messi", 500.0, 400.00));
            list.Add(new SavingsAccount(1003, "LeBron", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Harden", 500.0, 400.00));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}