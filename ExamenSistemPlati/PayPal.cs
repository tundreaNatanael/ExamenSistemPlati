using System;
namespace ExamenSistemPlati
{
	public class PayPal:PaymentSystem
	{
        public override void Print(decimal total)
		{ Console.WriteLine("PayPal Payment System was used"); }
    }
}

