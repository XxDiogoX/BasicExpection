using System;
using System.Collections.Generic;
using System.Text;
using ExercicioException.Entities.Exceptions;
using System.Globalization;

namespace ExercicioException.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(amount > WithDrawLimit && amount < Balance)
            {
                throw new DomainException("Withdrawn: The amount exceeds withdraw limit!!");
            }

            if(amount > Balance && amount < WithDrawLimit)
            {
                throw new DomainException("withdraw: Not enough balance!!");
            }

         

            Balance -= amount;
            WithDrawLimit -= amount;
            Console.WriteLine("New Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
            
        }

        public override string ToString()
        {
            return $"Number Account: {Number}\nHolder: {Holder}\nInitial balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}\nWithDraw Limit: {WithDrawLimit.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
