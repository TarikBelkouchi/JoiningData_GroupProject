using System;
namespace JoiningData
{
	public class CustomerOrder
	{
		public string CustomerName { get; set; }
		public string Item { get; set; }
		public decimal Price { get; set; }
		public int Quanity { get; set; }


		public CustomerOrder(string _customerName, string _item, decimal _price, int _quanity)
			{
				CustomerName = _customerName;
				Item = _item;
				Price = _price;
				Quanity = _quanity;
			}

	}

	//string[] cName = { "Acme Hardware", "Acme Hardware", "Falls Realty", "Julie's Morning Diner", "Julie's Morning Diner" };
	//string[] cItem = { "Mouse", "Keyboard", "Macbook", "iPad", "Credit Card Reader" }
	//decimal[] cPrice = { 25.00, 45.00, 800.00, 525.00, 45.00 };
	//int[] cQuanity = { 3, 2, 2, 1, 1 };



}





