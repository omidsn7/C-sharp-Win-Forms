﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();

        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The total Cost of Cart is {cart.GenerateTotal(Sumtotal, CalculateDiscount, TellUserDiscount):C2}");
            Console.WriteLine();

            decimal total = cart.GenerateTotal((subtotal) => Console.WriteLine($"The SubTotal For Cart2 is : {subtotal:C2}"),
                                                (Products, subtotal) =>
                                                {
                                                    if (Products.Count > 3)
                                                        return subtotal * 0.5M;
                                                    else
                                                        return subtotal;
                                                },
                                                (Message) => Console.WriteLine($"Cart 2 Alert {Message}"));

            Console.WriteLine($"The total cart2 is : {total:C2}");


            Console.WriteLine();
            Console.Write("Please press any key to exit the application...");
            Console.ReadKey();
        }

        private static void TellUserDiscount(string String)
        {
            Console.WriteLine(String);
        }

        private static void Sumtotal(Decimal sumTotal)
        {
            Console.WriteLine($"The total is : {sumTotal:C2}");
        }

        private static decimal CalculateDiscount(List<ProductModel> productModels, Decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.95M;
            }
            else
            {
                return subTotal;
            }
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}
