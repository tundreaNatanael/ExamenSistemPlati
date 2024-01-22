using System;
namespace ExamenSistemPlati
{
	public class CryptoWallet:PaymentSystem
	{
		public CryptoWallet(decimal total)
			:base (total)
		{ Console.WriteLine("Crypto Wallet Payment System was used"); }
	}
}

