using System;
namespace ExamenSistemPlati
{
	public class Order
	{
		public readonly string Customer = string.Empty;
		public readonly DateTime Date = DateTime.Now;
		public readonly decimal Total = 0M;

        public Order(string customer, DateTime date, decimal total)
		{
			Customer = customer;
			Date = date;
			Total = total;
		}
	}
}

