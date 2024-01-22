using System;
namespace ExamenSistemPlati
{
	public class OnlineCard:PaymentSystem
	{
		public OnlineCard(decimal total)
			:base (total)
		{ Console.WriteLine("Online Card Payment System was used"); }
	}
}

