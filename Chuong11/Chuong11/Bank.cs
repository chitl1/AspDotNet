using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Chuong11
{
    public class Bank
    {
        private List<Account> accounts = new List<Account>();
        private const int MaxAccounts = 100;

        public void CreateAccount()
        {
            if (accounts.Count >= MaxAccounts)
            {
                Console.WriteLine("Số lượng tài khoản đã đầy");
                return;
            }

            Console.Write("Nhập số tài khoản: ");
            double accNumber = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên tài khoản: ");
            string accName = Console.ReadLine();
            Console.Write("Nhập số tiền: ");
            double balance = double.Parse(Console.ReadLine());
            Account newAccount = new Account(accNumber, accName, balance);
            accounts.Add(newAccount);
            Console.WriteLine("Thêm mới tài khoản thành công");
        }

        public void Deposit()
        {

            Console.Write("Nhập số tài khoản: ");
            int accNumber = int.Parse(Console.ReadLine());
            Account account = FindAccount(accNumber);

            if (account != null)
            {
                Console.Write("Nhập số tiền muốn nạp: ");
                double depositAmount = double.Parse(Console.ReadLine());
                account.Deposit(depositAmount);
                Console.WriteLine("Nạp tiền vào tài khoản thành công");
            }
            else
            {
                Console.WriteLine("Tài khoản không tồn tại");
            }
        }

        public void Withdraw()
        {
            Console.Write("Nhập số tài khoản: ");
            int accNumber = int.Parse(Console.ReadLine());
            Account account = FindAccount(accNumber);
            if (account != null)
            {
                Console.Write("Nhập số tiền muốn rút: ");
                double withdrawAmount = double.Parse(Console.ReadLine());
                account.Withdraw(withdrawAmount);
                Console.Write("Rút tiền thành công");
            }
            else
            {
                Console.WriteLine("Tài khoản không tồn tại");
            }
        }

        public void DisplayAccounts()
        {
            foreach (var account in accounts)
            {
                if (account.accountBalance > 100)
                {
                    Console.WriteLine(account);
                }
            }
        }

        private Account FindAccount(int accountNumber)
        {
            return accounts.Find(account => account.accountNumber == accountNumber);
        }
    }
}