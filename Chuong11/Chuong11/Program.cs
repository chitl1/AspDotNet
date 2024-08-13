using Chuong11;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Bank bank = new Bank();


do
{
    Console.WriteLine("\nMenu");
    Console.WriteLine("--------------------------");
    Console.WriteLine("1. Create an Account");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Deposit");
    Console.WriteLine("4. Save to file");
    Console.WriteLine("5. Display");
    Console.WriteLine("6. Exit");
    Console.Write("Your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:

            bank.CreateAccount();
            break;

        case 2:
            bank.Withdraw();
            break;

        case 3:
            bank.Deposit();
            break;

        case 4:

            break;

        case 5:
            bank.DisplayAccounts();
            break;

        case 6:
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Nhập sai số, Hãy chọn lại");
            break;
    }
} while (true);
        