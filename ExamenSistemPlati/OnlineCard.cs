using System;
namespace ExamenSistemPlati
{
	public class OnlineCard:PaymentSystem
	{
		public override void Print(decimal total)
		{ Console.WriteLine("Online Card Payment System was used"); }
	}
}

