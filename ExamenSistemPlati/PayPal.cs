using System;
namespace ExamenSistemPlati
{
	public class PayPal:PaymentSystem
	{
		public PayPal(decimal total)
			:base (total)
		{ Console.WriteLine("PayPal Payment System was used"); }
	}
}

