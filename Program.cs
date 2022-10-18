using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShopperApp
{
    internal class Program
    {
        // global class variables
        public static int money = 100;
        // shopCounter1 has no checkout or addfunds option.
        public static void ShopCounter1()
        {
            // *when adding log in section make user a lucky shopper winner who gets $100 voucher
            Console.WriteLine("\n******************************************************\t\t\t\t\t       ***************");
            Console.WriteLine("\t\t  WELCOME TO HATRICK\t\t\t\t\t\t\t\tOnline Shopper");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tBalance : ${money}");
            Console.WriteLine("******************************************************\t\t\t\t\t       ***************");
            Console.WriteLine("\tPress [m] for Mens Hats\n");
            Console.WriteLine("\tPress [w] for Womens Hats\n");
            Console.WriteLine("\tPress [k] for Kids Hats\n");
            Console.WriteLine("\tPress [x] to exit the app/Log out\n");
            Console.WriteLine("******************************************************");
            Console.Write("\tPlease select from the options menu: ");

            // switch statement user input check
            switch (Console.ReadLine())
            {
                case "m":
                    CategoryOne();
                    break;
                case "w":
                    CategoryTwo();
                    break;
                case "k":
                    CategoryThree();
                    break;
                case "x":
                    Exit();
                    break;
                default:
                    Console.Clear();
                    ShopCounter();
                    break;

            }

        }

        public static void ShopCounter()
        {
            Console.WriteLine("\n******************************************************\t\t\t\t\t       ***************");
            Console.WriteLine("\t\t  WELCOME TO HATRICK\t\t\t\t\t\t\t\tOnline Shopper");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tBalance : ${money}");
            Console.WriteLine("******************************************************\t\t\t\t\t       ***************");
            Console.WriteLine("\tPress [m] for Mens Hats\n");
            Console.WriteLine("\tPress [w] for Womens Hats\n");
            Console.WriteLine("\tPress [k] for Kids Hats\n");
            Console.WriteLine("\tPress [a] to add funds to your balance\n");
            Console.WriteLine("\tPress [c] to go to checkout\n");
            Console.WriteLine("\tPress [x] to exit the app/Log out\n");
            Console.WriteLine("******************************************************");
            Console.Write("\tPlease select from the options menu: ");

            switch (Console.ReadLine())
            {
                case "m":
                    CategoryOne();
                    break;
                case "w":
                    CategoryTwo();
                    break;
                case "k":
                    CategoryThree();
                    break;
                case "a":
                    AddFunds();
                    break;
                case "c":
                    CheckOut();
                    break;
                case "x":
                    Exit();
                    break;
                default:
                    Console.Clear();
                    ShopCounter();
                    break;

            }

        }

        public static void CategoryOne()
        {
            Console.Clear();
            Console.WriteLine("\n******************************************************");
            Console.WriteLine("\t\t    Mens Hats");// the only line that changes per catergory
            Console.WriteLine("******************************************************\n");
            Console.WriteLine("\tPress [1] to purchase 1 Red Hat     -    ($10)\n");
            Console.WriteLine("\tPress [2] to purchase 1 Blue Hat    -    ($10)\n");
            Console.WriteLine("\tPress [3] to purchase 1 Black Hat   -    ($10)\n");
            Console.WriteLine("\tPress [4] to purchase 1 White Hat   -    ($10)\n");
            Console.WriteLine("\tPress [r] to return to Shop Counter\n");
            Console.WriteLine("******************************************************");
            Console.Write("\tPlease select from the options menu: ");

            if (money <= 0)
            {
                Console.WriteLine("\n******************************************************");
                Console.WriteLine("\n Sorry, you have in-sufficient funds to make a purchase.");
                Console.WriteLine("\n Press [r] to return to Shop Counter to add to your balance or checkout.");
            }

            switch (Console.ReadLine())
            {
                case "1":
                    money -= 10;
                    Console.Write($"\t\nYou have purchased 1 Red Hat for $10. Your remaining balance is ${money}");
                    Console.ReadKey();
                    Console.Clear();
                    CategoryOne();
                    break;
                case "2":
                    money -= 10;
                    Console.Write($"\t\nYou have purchased 1 Blue Hat for $10. Your remaining balance is ${money}");
                    Console.ReadKey();
                    CategoryOne();
                    break;
                case "3":
                    money -= 10;
                    Console.Write($"\t\nYou have purchased 1 Black Hat for $10. Your remaining balance is ${money}");
                    Console.ReadKey();
                    CategoryOne();
                    break;
                case "4":
                    money -= 10;
                    Console.Write($"\t\nYou have purchased 1 White Hat for $10. Your remaining balance is ${money}");
                    Console.ReadKey();
                    CategoryOne();
                    break;
                case "r":
                    Console.Clear();
                    ShopCounter();
                    break;
                default:
                    Console.Clear();
                    CategoryOne();
                    break;
            }

        }

        public static void CategoryTwo()
        {
            Console.Clear();

        }

        public static void CategoryThree()
        {
            Console.Clear();

        }

        public static void AddFunds()
        {
            Console.Write("\n\tPlease enter the amount of funds you wish to add $");
            money = int.Parse(Console.ReadLine()) + money;
            Console.WriteLine($"\n\tCurrent balance available is now ${money}");
            Console.ReadKey();
            Console.Clear();
            ShopCounter();
        }


        public static void CheckOut()
        {

            Console.WriteLine("\n You have sucessfully checked out..");
            Console.WriteLine("\n We hope you enjoy your new hats.");
            Console.WriteLine("\n******************************************************");
            Console.WriteLine("\tPress [x] to exit the app / Log out\n");
            Console.Write("\t");


            switch (Console.ReadLine())
            {
                case "x":
                    Exit();
                    break;
                default:
                    Console.Clear();
                    CheckOut();
                    break;
            }

        }


        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\n You have sucessfully logged out.");
            Console.WriteLine("\n Thanks for shopping at HATRICK. We hope to see you again soon.\n");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            ShopCounter1();
        }
    }
}