Console.Write("Number of small carpets: ");
int small=Convert.ToInt32(Console.ReadLine());

Console.Write("Number of Large carpets: ");
int large = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Price per small room: $25");
Console.WriteLine("Price per Large room: $35");

decimal pricePersmall = small * 25;
decimal pricePerlarge = large * 35;


decimal cost = pricePersmall+ pricePerlarge;
Console.WriteLine($"cost: {cost}");


decimal tax = cost * (6m / 100m);
Console.WriteLine($"Tax: {tax}");
Console.WriteLine("_________________________________________");
Console.WriteLine("_________________________________________");

decimal total = cost + tax;
Console.WriteLine($"Total  estimate: {total}");
Console.WriteLine("This estimate is valid for 30 days");










