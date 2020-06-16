using System;

namespace SeleniumBasicDemo
{
    
    public class BankAcount
    {
        decimal amount;

        public BankAcount()
        {
        }

        public BankAcount(decimal initAmount)
        {
            this.Amount = initAmount;
        }

        public decimal Amount
        {
            get
            {
                return this.amount;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Amount can not be negative!");
                }
                else
                {
                    this.amount = value;
                }
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit can not be negative!");
            }
            this.Amount += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 1000 && amount > 0)
            {
                amount += (amount * 0.05m);
                this.Amount -= amount;
            }
            else if(amount >= 1000)
            {
                amount += (amount * 0.02m);
                this.Amount -= amount;
            } else if (amount <= 0)
            {
                throw new ArgumentException("Withraw can not be negative!");               
            }
            
        }
    }
}
