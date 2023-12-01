using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Dog_OOP
{
    internal class Bank
    {
        public int _accountNumber;
        public string _accountType;
        public double _balance;

        public Bank(int accountNumber, string accountType, double balance)
        {
            _accountNumber = accountNumber;
            _accountType = accountType;
            _balance = balance;
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public double Deposit(double amount)
        {
            _balance += amount;
            return _balance;
        }
        public double Withdraw(double amount)
        {
            _balance -= amount;
            return amount;
        }
    }
}
