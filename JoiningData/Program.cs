using JoiningData;

CustomerOrder[] co = new CustomerOrder[]
{
        new CustomerOrder("Acme Hardware", "Mouse", 25.00m, 3),
        new CustomerOrder("Acme Hardware", "Keyboard", 45.00m, 2),
        new CustomerOrder("Falls Reality", "Macbook", 800.00m,2),
        new CustomerOrder("Julie's Morning Diner", "iPad", 525.00m, 1),
        new CustomerOrder("Julie's Morning Diner", "Credit Card Reader", 45.00m, 1)

};
//pt 2
//string currentName = "";
//decimal orderTotal = 0;
//for (int i = 0; i < co.Length; i++)
//{
//    decimal totalPrice = co[i].Price * co[i].Quanity;
//    orderTotal += totalPrice;
//    if (currentName != co[i].CustomerName)
//    {
//        currentName = co[i].CustomerName;
//        Console.WriteLine($"{co[i].CustomerName}");
//        Console.WriteLine("\t" + String.Format("{0,-25}{1,10}{2,10}{3,10}", "Item", "Price", "Quanity", "Total"));
//    }
//    Console.WriteLine("\t" + String.Format("{0,-25}{1,10}{2,10}{3,10}", co[i].Item, co[i].Price, co[i].Quanity, totalPrice));
//    if ((i + 1) == co.Length || co[i].CustomerName != co[i + 1].CustomerName)
//    {
//        Console.WriteLine("\t" + String.Format("{0,-25}{1,10}{2,10}{3,10}", "Total", "", "", orderTotal));
//        orderTotal = 0;
//    }

//}
string currentName = "";
decimal orderTotal = 0;
Console.WriteLine(String.Format("{0,-25}{1,20}{2,10}{3,10}{4,15}", "Customer", "Item", "Price", "Quanity", "Total"));
for (int i = 0; i < co.Length; i++)
{
    decimal totalPrice = co[i].Price * co[i].Quanity;
    orderTotal += totalPrice;

    if (currentName != co[i].CustomerName)
    {
        currentName = co[i].CustomerName;
        Console.WriteLine(String.Format("{0,-25}{1,20}{2,10}{3,10}{4,15}", co[i].CustomerName, co[i].Item, co[i].Price, co[i].Quanity, totalPrice));
    }
    else 
    {
        Console.WriteLine(String.Format("{0,-25}{1,20}{2,10}{3,10}{4,15}", "", co[i].Item, co[i].Price, co[i].Quanity, totalPrice))
    }
}
