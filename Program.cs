namespace ConsoleApp7;
using System.Collections.Generic;
using System.Net.Http.Headers;

internal class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Welcome, Type your Name: ");
        string name = Console.ReadLine();
        Console.Write($"Welcome {name}, Enter 4-numbers pin: ");
        int pin = Convert.ToInt32(Console.ReadLine());
        Console.Write($"re-enter your pin: ");
        int repin = Convert.ToInt32(Console.ReadLine());
        while (pin != repin)
        {
            Console.WriteLine("Receive your card");
            return;
        }
        int balance = 0;
        Console.WriteLine($"your balance is {balance} ");
        /*
         Create accounts
        Deposit money
        Withdraw money
        Check balance
        View transaction history.
         */
        List<string> Histoty = new List<string>();
        int x;
        int amount;
        while (true)
        {
            Console.Write($"Choose one option and type it's number\n1.deposit\n2.withdraw money\n3.check balance\n4.view history\n5.exist\n>>>");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.Write($"Enter the amount to deposit: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    balance += amount;
                    Console.WriteLine($"you entered {amount} EGP and your Balance is: {balance} ");
                    Histoty.Add($"you deposit {amount} EGP");
                    break;
                case 2:
                    Console.Write($"Enter the amount to withdraw: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    balance -= amount;
                    Console.WriteLine($"thank you!\nyou withdrew {amount} and you're balance is: {balance}");
                    Histoty.Add($"you withdrew {amount} EGP");

                    break;
                case 3:
                    Console.WriteLine($"your balance is {balance}");
                    break;
                case 4:
                    foreach (var ele in Histoty)
                    {
                        Console.WriteLine(ele);
                    }
                    break;
                case 5:
                    Console.WriteLine("Thank you :) ");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;


            }
        }




    }
}
