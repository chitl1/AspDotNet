using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong11
{
    public class Account
    {
        public double accountNumber;
        public string accountName;
        public double accountBalance;
        public Account(double AccountNumber, string AccountName, double AccountBalance)
        {
            accountNumber = AccountNumber;
            accountName = AccountName;
            accountBalance = AccountBalance;
        }
        public override string ToString()
        {
            return "Tên tài khoản : " + accountName + ", stk: " + accountNumber + " , Số dư : " + accountBalance;
        }
        public void Deposit(double amount)
        {
            accountBalance += amount;
        }

        public void Withdraw(double amount)
        {
            if (accountBalance >= amount)
            {
                accountBalance -= amount;
            }
            else
            {
                Console.WriteLine("Số tiền trong tài khoản còn không đủ !");
            }

        }
    }
}
