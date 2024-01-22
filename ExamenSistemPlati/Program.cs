using System;

namespace ExamenSistemPlati
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(">>> Start app");

            Console.Write(">>> Customer name:  ");
            string customer = Console.ReadLine();

            Console.Write(">>> Total:  ");
            decimal total = decimal.Parse(Console.ReadLine());

            Console.WriteLine(@"There are 3 types of payment:
OnlineCard
PayPal
CryptoWallet");
            Console.Write(">>> Type of payment (please type exactly the same word as above):  ");
            string systemtype = Console.ReadLine();

            if (systemtype== "OnlineCard") OrderProcessor.FulfillOrder(new Order(customer, DateTime.Now, total), new OnlineCard(total));
            else
            {
                if (systemtype == "PayPal") OrderProcessor.FulfillOrder(new Order(customer, DateTime.Now, total), new PayPal(total));
                else OrderProcessor.FulfillOrder(new Order(customer, DateTime.Now, total), new CryptoWallet(total));
            }
            Console.Read();
            
        }
    }
}