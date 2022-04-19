using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //client account creation
            Client bruce = new Client("Bruce Wayne", "1007 Mtn Drive, Gotham", "Bat-Signal", 0001134, 0007134);
            Chequing chequing = new Chequing("Checking Account", 0001134, 500);
            Saving saving = new Saving("Savings Account", 0007134, 2000.00, 200);

            //do
            //{
            //    Console.WriteLine("Welcome to DogeBank\n\nWhat is your account name?\n--exit to exit");
            //    string accountNumber = Console.ReadLine();
            //    if (accountNumber == "exit" || accountNumber == "exit")
            //    {
            //        Environment.Exit(0);
            //    }
            //    else
            //    {

            //menu navigation
            do
            {
                Console.WriteLine("============ Main Menu ============");
                Console.WriteLine("1. View Client Info");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Finish and Exit");
                Console.WriteLine("===================================");
                int menuItem = int.Parse(Console.ReadLine());
                switch (menuItem)
                {
                    case 1:
                        bruce.ClientInfo();
                        break;
                    case 2:
                        Console.WriteLine("====== View Account Balance =======");
                        Console.WriteLine("Please select account");
                        Console.WriteLine("1. Chequing");
                        Console.WriteLine("2. Saving");
                        Console.WriteLine("===================================");
                        menuItem = int.Parse(Console.ReadLine());
                        switch (menuItem)
                        {
                            case 1:
                                chequing.AccInfo();
                                break;
                            case 2:
                                saving.AccInfo();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("============= Deposit =============");
                        Console.WriteLine("Please select account");
                        Console.WriteLine("1. Chequing");
                        Console.WriteLine("2. Saving");
                        Console.WriteLine("===================================");
                        menuItem=int.Parse(Console.ReadLine());
                        switch (menuItem)
                        {
                            case 1:
                                chequing.AccDeposit();
                                break;
                            case 2:
                                saving.AccDeposit();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("============ Withdraw =============");
                        Console.WriteLine("Please select account");
                        Console.WriteLine("1. Chequing");
                        Console.WriteLine("2. Saving");
                        Console.WriteLine("===================================");
                        menuItem = int.Parse(Console.ReadLine());
                        switch (menuItem)
                        {
                            case 1:
                                chequing.AccWithdraw();
                                break;
                            case 2:
                                saving.AccWithdraw();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

            }
            while (true);
            //    }

            //}while (true);
        }
    }
}