﻿using System;

namespace BankingDomain
{
    public class BankAccount
    {
        private decimal _currentBalance = 5000;

        public decimal GetBalance()
        {
            return _currentBalance;
        }

        // Overridable
        public virtual void Deposit(decimal amountToDeposit)
        {
            this._currentBalance += amountToDeposit;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if(amountToWithdraw <= _currentBalance)
            {
                _currentBalance -= amountToWithdraw;
            } else
            {
                throw new OverdraftException();
            }
            
        }
    }
}