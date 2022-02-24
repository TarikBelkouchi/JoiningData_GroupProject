using JoiningData;

CustomerOrder[] co = new CustomerOrder[]
{
		new CustomerOrder("Acme Hardware", "Mouse", 25.00m, 3),
		new CustomerOrder("Acme Hardware", "Keyboard", 45.00m, 2),
		new CustomerOrder("Falls Reality", "Macbook", 800.00m,2),
		new CustomerOrder("Julie's Morning Diner", "iPad", 525.00m, 1),
		new CustomerOrder("Julie's Morning Diner", "Credit Card Reader", 45.00m, 1)

};

string currentName = "";


foreach(CustomerOrder c in co)
{
	if (currentName != c.CustomerName)
    {
		currentName = c.CustomerName;
		Console.WriteLine($"{c.CustomerName}");
		Console.WriteLine("\tItem Price Quanity Total");
      
        
	}

	decimal totalPrice = c.Price * c.Quanity;

	
	Console.WriteLine($"\t{c.Item} {c.Price} {c.Quanity} {totalPrice}");
    
}