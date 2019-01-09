using System;

namespace Lab2
{
    class Program
    {
        public static double balance = 1000;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM");
            UserInterface();
        }

        static void UserInterface()
        {

            bool running = true;
            while (running)
            {
                Console.WriteLine("Please choose option 1, 2, 3, or 4");
                Console.WriteLine("1.Withdrawal");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.View Balance");
                Console.WriteLine("4.Exit");

                string userSelection = Console.ReadLine();
                int userSelect = Convert.ToInt32(userSelection);

                if (userSelect == 1 || userSelect == 2 || userSelect == 3 || userSelect == 4)
                {
                    double amount;
                    switch (userSelect)
                    {

                        case 1:
                            Console.WriteLine("How much would you like to withdrawal?");
                            string withdrawalAmount = Console.ReadLine();
                            amount = Convert.ToInt32(withdrawalAmount);
                            Withdrawal(amount);
                            break;

                        case 2:
                            Console.WriteLine("How much would you like to deposit?");
                            string depositAmount = Console.ReadLine();
                            amount = Convert.ToInt32(depositAmount);
                            Deposit(amount);
                            break;

                        case 3:
                            Console.WriteLine($"Your balance is {balance}");
                            break;

                        default:
                            Environment.Exit(0);
                            break;

                    }
                }

                else
                {
                    Console.WriteLine("Please select options 1, 2, 3, or 4");
                    UserInterface();
                }

            }
        }

        public static void Withdrawal(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine($"{ amount} is more then your current balance of {balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine($"Please enter a valid amount");
            }

            else
            {
                balance -= amount;
                Console.WriteLine($"Withdeawal Complete, your new balance is {balance}");
            }
        }

        public static void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"deposit complete, new balance is {balance}");
            }

            else
            {
                Console.WriteLine("this is not a valid amount");
                UserInterface();
            }
        }

    }
}
