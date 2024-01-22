using System;
namespace ExamenSistemPlati
{
	public class CryptoWallet:PaymentSystem
	{
        public override void Print(decimal total)
		{ Console.WriteLine("CryptoWallet Payment System was used"); }
    }
}

