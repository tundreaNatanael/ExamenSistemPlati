using System;
namespace ExamenSistemPlati
{
	public class OrderProcessor
	{
		public static void FulfillOrder(Order order, PaymentSystem paymentSystem)
		{
			Console.WriteLine($"{order.Customer} bought at {order.Date} for {order.Total} $");
			PaymentSystem temporary = paymentSystem;
		}
	}
}

