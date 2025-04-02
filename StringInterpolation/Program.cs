string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine(input.PadRight(12));

string newReturnString = $"{newReturn:P2}";
string currentReturnString = $"{currentReturn:P2}";
string currentMessage = "";

currentMessage = String.Format($"{currentProduct.PadRight(18)}{currentReturnString.PadRight(10)}{currentProfit:C}");
comparisonMessage = String.Format($"{newProduct.PadRight(18)}{newReturnString.PadRight(10)}{newProfit:C}");

Console.WriteLine(currentMessage);
Console.WriteLine(comparisonMessage);

// Another way ---------------------
// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);