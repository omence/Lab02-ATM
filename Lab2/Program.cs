using System;

namespace Lab2
{
    public class Program
    {   //Bank Balance
        public static double balance = 1000;

        //Main method, idtro and intercae call
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM");
            UserInterface();
        }
        //user interface
        static void UserInterface()
        {
            //interface is running

            bool running = true;

            //while the interface is runn run this code
            while (running)
            {  
                //options shown to user
                Console.WriteLine("Please choose option 1, 2, 3, or 4");
                Console.WriteLine("1.Withdrawal");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.View Balance");
                Console.WriteLine("4.Exit");

                //read user input and convert it to an int
                try
                {
                    string userSelection = Console.ReadLine();

                    int userSelect = Convert.ToInt32(userSelection);


                    //if the user chooses a valid option run this code
                    if (userSelect == 1 || userSelect == 2 || userSelect == 3 || userSelect == 4)
                    {
                        double amount;
                        switch (userSelect)
                        {
                            //if user chooses withdrawal
                            case 1:
                                Console.WriteLine("How much would you like to withdrawal?");
                                string withdrawalAmount = Console.ReadLine();
                                amount = Convert.ToInt32(withdrawalAmount);
                                Withdrawal(amount);
                                Console.WriteLine($"Your new balance is {balance}");
                                break;
                            //if user chooses deposit
                            case 2:
                                Console.WriteLine("How much would you like to deposit?");
                                string depositAmount = Console.ReadLine();
                                amount = Convert.ToInt32(depositAmount);
                                Deposit(amount);
                                Console.WriteLine($"Your new balance is {balance}");
                                break;
                            //if user chooses to view balance
                            case 3:
                                Console.WriteLine($"Your balance is {balance}");
                                break;
                            //default
                            default:
                                UserInterface();
                                break;

                        }
                    }

                    else
                    {   //if user chooses an invalid option
                        Console.WriteLine("Please select options 1, 2, 3, or 4");
                        UserInterface();
                    }
                }
                catch
                {
                    Console.WriteLine("please choose a valid option");
                }
            }
        }
        //code for handling withdrawal
        public static string Withdrawal(double amount)
        {
            try
            {   //if there is not enough money in account
                if (amount > balance)
                {
                    return $"{ amount} is more then your current balance of {balance}";
                }
                //
                else if (amount <= 0)
                {    //if user choose 0 to withdrawal
                    Console.WriteLine("Amount was not valid");
                    return "Amount was not valid";
                }

                else
                {   //complete the withdrawal
                    balance -= amount;
                    Console.WriteLine($"Withdeawal Complete, your new balance is {balance}");
                    return $"Withdeawal Complete, your new balance is {balance}";
                }
            }

            catch(Exception e)
            {
                throw e;
              
            }
        }
        //code for deposit
        public static string Deposit(double amount)
        {   // if amount is more then nothing then complete deposit
            if (amount > 0)
            {
                balance += amount;
                return $"deposit complete, new balance is {balance}";
            }
            //otherwise alert user
            else
            {
                Console.WriteLine("this is not a valid amount");
                return "this is not a valid amount";
                
            }
        }

    }
}
