using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using KomplexaDatatyperKata;

namespace KomplexaDatatyperKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ordering = true;
            string choice2;
            int amountBike = 0;
            int amountTrampoline = 0;
            int amountBouquet = 0;
            int total = 0;

            List<int> orderlistBike = new List<int>();
            List<int> orderlistTrampoline = new List<int>();
            List<int> orderlistBouquet = new List<int>();
            List<int> orderlistOther = new List<int>();
            List<string> otherStringList = new List<string>();
            List<int> totalOrderList = new List<int>();


            OnlineOrders var1 = new OnlineOrders();
            OnlineOrders x = var1;


            while (ordering)
            {

                Console.Clear();

                Console.WriteLine("1: Order an electric bicycle");
                Console.WriteLine("2: Order a Trampoline");
                Console.WriteLine("3: Order a Bouquet");
                Console.WriteLine("4: Order something else");
                Console.WriteLine("5: Show all orders");
                Console.WriteLine("7: Exit");

                Console.Write("Type option and press enter:");
                int choice = int.Parse(Console.ReadLine());


                Console.Clear();

                if (choice == 1)
                {
                    x.orderName = "Electric Bicycle";
                    x.Value = "900$";
                    orderlistBike.Add(1);
                }

                if (choice == 2)
                {
                    x.orderName = "Trampoline";
                    x.Value = "199$";
                    orderlistTrampoline.Add(1);
                }

                if (choice == 3)
                {
                    x.orderName = "Bouquet";
                    x.Value = "9.99$";
                    orderlistBouquet.Add(1);
                }

                if (choice == 4)
                {
                    string other = (Console.ReadLine());
                    x.orderName = other;
                    x.Value = "unknown";
                    orderlistOther.Add(1);
                    otherStringList.Add(other);
                }

                if (choice == 5)
                {

                    amountBike = orderlistBike.Count;
                    amountTrampoline = orderlistTrampoline.Count;
                    amountBouquet = orderlistBouquet.Count;

                    total = (orderlistBike.Count + orderlistTrampoline.Count + orderlistBouquet.Count + orderlistOther.Count);
                    totalOrderList.Add(total);

                    if (totalOrderList.Count > 0)
                    {
                        Console.WriteLine("Total items in cart: " + " " + total);
                    }

                    if (orderlistBike.Count > 0)
                    {
                        Console.WriteLine("You ordered " + amountBike + " " + "Electric Bicycle");
                    }

                    if (orderlistTrampoline.Count > 0)
                    {
                        Console.WriteLine("You ordered " + amountTrampoline + " Trampolines");
                    }

                    if (orderlistBouquet.Count > 0)
                    {
                        Console.WriteLine("You ordered " + amountBouquet + " Bouquets");
                    }

                    if (orderlistOther.Count > 0)
                    {
                        var q = from other in otherStringList
                                group other by other
                            into g
                                let count = g.Count()
                                orderby count descending
                                select new { Value = g.Key, Count = count };
                        foreach (var other in q)
                        {
                            Console.WriteLine("You ordered " + other.Count + " " + other.Value);

                        }

                    }

                    
                    Console.WriteLine("Order Number: " + x.orderNumber);
                    Console.WriteLine("Total Sum: " + var1.Value);
                    Console.WriteLine("");
                    Console.WriteLine("order more? y/n");

                    choice2 = (Console.ReadLine());
                    if (choice2 == "y")
                    {
                    }
                    else if (choice2 == "n")
                    {
                        ordering = false;
                    }



                }
                Console.Clear();
            }

        }
    }
}
