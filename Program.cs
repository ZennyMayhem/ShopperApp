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
            // login function
        public static void Login()
        {
            // ask user to enter username
            Console.Write("\n\t Please enter a username:");
            Console.ReadLine();
            Console.Clear();

            // ask user to enter password
            Console.Write("\n\t Please enter a password:");
            Console.ReadLine();
            Console.Clear();

            Console.Write("\n\tYou have sucessfully signed up with Hatrick.");
            Console.ReadKey();
            Console.Clear();
            // give user store credit
            Console.WriteLine("\n\tCongratulations!!! You are our lucky 1,000th member. ");
            Console.Write("\n\tHere's $100 free store credit.");
            Console.ReadKey();
            Console.Clear();
           
            ShopCounter1();
        }



// global class variable
public static int money = 100;
        
            // initial Menu function
        public static void ShopCounter1()
        {
            // options menu display
            Console.WriteLine("\n******************************************************\t\t\t\t\t       ***************");
            Console.WriteLine("\t\t WELCOME TO HATRICK\t\t\t\t\t\t\t\tOnline Shopper");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tBalance : ${money}");
            Console.WriteLine("******************************************************\t\t\t\t\t       ***************");
            Console.WriteLine("\tPress [m] for Mens Hats\n");
            Console.WriteLine("\tPress [w] for Womens Hats\n");
            Console.WriteLine("\tPress [k] for Kids Hats\n");
            Console.WriteLine("\tPress [x] to Log out\n");
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
            // default prevents incorrect user input
                default:
                    Console.Clear();
                    ShopCounter1();
                    break;

            }

        }
            // main Menu function
        public static void ShopCounter()
        {
            // options menu display
            Console.WriteLine("\n******************************************************\t\t\t\t\t       ***************");
            Console.WriteLine("\t\t  WELCOME TO HATRICK\t\t\t\t\t\t\t\tOnline Shopper");
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tBalance : ${money}");
            Console.WriteLine("******************************************************\t\t\t\t\t       ***************");
            Console.WriteLine("\tPress [m] for Mens Hats\n");
            Console.WriteLine("\tPress [w] for Womens Hats\n");
            Console.WriteLine("\tPress [k] for Kids Hats\n");
            Console.WriteLine("\tPress [a] to add funds to your balance\n");
            Console.WriteLine("\tPress [c] to go to checkout\n");
            Console.WriteLine("\tPress [x] to Log out\n");
            Console.WriteLine("******************************************************");
            Console.Write("\tPlease select from the options menu: ");

            // user input check
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
            // product menu 1 funtion
        public static void CategoryOne()
        {
            // options menu
            Console.Clear();
            Console.WriteLine("\n******************************************************");
            Console.WriteLine("\t\t    Mens Hats");
            Console.WriteLine("******************************************************\n");
            Console.WriteLine("\tPress [1] to purchase 1 Red Hat     -    ($10)\n");
            Console.WriteLine("\tPress [2] to purchase 1 Blue Hat    -    ($10)\n");
            Console.WriteLine("\tPress [3] to purchase 1 Black Hat   -    ($10)\n");
            Console.WriteLine("\tPress [4] to purchase 1 White Hat   -    ($10)\n");
            Console.WriteLine("\tPress [5] to purchase 1 Pink Hat    -    ($10)\n");
            Console.WriteLine("\tPress [r] to return to Shop Counter\n");
            Console.WriteLine("******************************************************");
            Console.Write("\tPlease select from the options menu: ");
            // zero balance default
            if (money <= 0)
            {
                Console.WriteLine("\n******************************************************");
                Console.WriteLine("\n Sorry, you have in-sufficient funds to make a purchase.");
                Console.WriteLine("\n Press [r] to return to Shop Counter to add to your balance or checkout.");
            }
            // *need to add option to confirm item purchase BEFORE balance update
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
                case "5":
                    money -= 10;
                    Console.Write($"\t\nYou have purchased 1 Pink Hat for $10. Your remaining balance is ${money}");
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
            {
                // product menu 2
                Console.Clear();
                Console.WriteLine("\n******************************************************");
                Console.WriteLine("\t\t    Womens Hats");
                Console.WriteLine("******************************************************\n");
                Console.WriteLine("\tPress [1] to purchase 1 Red Hat     -    ($10)\n");
                Console.WriteLine("\tPress [2] to purchase 1 Blue Hat    -    ($10)\n");
                Console.WriteLine("\tPress [3] to purchase 1 Black Hat   -    ($10)\n");
                Console.WriteLine("\tPress [4] to purchase 1 White Hat   -    ($10)\n");
                Console.WriteLine("\tPress [5] to purchase 1 Pink Hat    -    ($10)\n");
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
                        CategoryTwo();
                        break;
                    case "2":
                        money -= 10;
                        Console.Write($"\t\nYou have purchased 1 Blue Hat for $10. Your remaining balance is ${money}");
                        Console.ReadKey();
                        CategoryTwo();
                        break;
                    case "3":
                        money -= 10;
                        Console.Write($"\t\nYou have purchased 1 Black Hat for $10. Your remaining balance is ${money}");
                        Console.ReadKey();
                        CategoryTwo();
                        break;
                    case "4":
                        money -= 10;
                        Console.Write($"\t\nYou have purchased 1 White Hat for $10. Your remaining balance is ${money}");
                        Console.ReadKey();
                        CategoryTwo();
                        break;
                    case "5":
                        money -= 10;
                        Console.Write($"\t\nYou have purchased 1 Pink Hat for $10. Your remaining balance is ${money}");
                        Console.ReadKey();
                        CategoryTwo();
                        break;
                    case "r":
                        Console.Clear();
                        ShopCounter();
                        break;
                    default:
                        Console.Clear();
                        CategoryTwo();
                        break;
                }

            }
        }
                // product menu 3
        public static void CategoryThree()
        {
            Console.Clear();
            {
                
                Console.Clear();
                Console.WriteLine("\n******************************************************");
                Console.WriteLine("\t\t    Kids Hats");
                Console.WriteLine("******************************************************\n");
                Console.WriteLine("\tPress [1] to purchase 1 Red Hat     -    ($10)\n");
                Console.WriteLine("\tPress [2] to purchase 1 Blue Hat    -    ($10)\n");
                Console.WriteLine("\tPress [3] to purchase 1 Black Hat   -    ($10)\n");
                Console.WriteLine("\tPress [4] to purchase 1 White Hat   -    ($10)\n");
                Console.WriteLine("\tPress [5] to purchase 1 Pink Hat    -    ($10)\n");
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
                        CategoryThree();
                        break;
                    case "2":
                        money -= 10;
                        Console.Write($"\t\nYou have purchased 1 Blue Hat for $10. Your remaining balance is ${money}");
                        Console.ReadKey();
                        CategoryThree();
                        break;
                    case "3":
                        money -= 10;
                        Console.Write($"\t\nYou have purchased 1 Black Hat for $10. Your remaining balance is ${money}");
                        Console.ReadKey();
                        CategoryThree();
                        break;
                    case "4":
                        money -= 10;
                        Console.Write($"\t\nYou have purchased 1 White Hat for $10. Your remaining balance is ${money}");
                        Console.ReadKey();
                        CategoryThree();
                        break;
                    case "5":
                        money -= 10;
                        Console.Write($"\t\nYou have purchased 1 Pink Hat for $10. Your remaining balance is ${money}");
                        Console.ReadKey();
                        CategoryThree();
                        break;
                    case "r":
                        Console.Clear();
                        ShopCounter();
                        break;
                    default:
                        Console.Clear();
                        CategoryThree();
                        break;
                }

            }
        }

        public static void AddFunds()
        {
            Console.Write("\n\tPlease enter the amount of funds you wish to add $");
            money = int.Parse(Console.ReadLine()) + money;
            Console.WriteLine("");
            Console.Write($"        Your available balance will be ${money}");
            Console.ReadKey();
            Console.Clear();
            ShopCounter();
        }

            // checkout function
        public static void CheckOut()
        {
            
            Console.WriteLine("\n You have successfully checked out..");
            Console.WriteLine("\n We hope you enjoy your new hats.");
            Console.WriteLine("\n******************************************************");
            Console.WriteLine("\tPress [x] to Log out\n");
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

            // logout function
        public static void Exit()
        {
            
            Console.Clear();
            Console.WriteLine("\n You have successfully logged out.");
            Console.WriteLine("\n Thanks for shopping at HATRICK. We hope to see you again soon.\n");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            Login();
        }
    }
}