// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//!  frmat
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
string result1 = string.Format("{0} {0}!", first, second);
string result2 = string.Format("{0} {0} {0}!", first, second);
Console.WriteLine(result);
Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P}");
Console.WriteLine($"Tax rate: {tax:P2}");
// decimal price = 67.55m;
decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// Console.WriteLine(yourDiscount);
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N6} Product");
Console.WriteLine($"     Sub Total: {subtotal:C2}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");
//! padding
string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));
 Console.WriteLine(input.PadLeft(12));
 Console.WriteLine(input.PadLeft(12).Length);
//  string paymentId = "769C";

//  var formattedLine = paymentId.PadRight(6);

//  Console.WriteLine(formattedLine);
// string paymentId = "769C";
//  string payeeName = "Mr. Stephen Ortega";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24);

//  Console.WriteLine(formattedLine);


// string paymentId = "769C";
//  string payeeName = "Mr. Stephen Ortega";
//  string paymentAmount = "$5,000.00";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24);
//  formattedLine += paymentAmount.PadLeft(10);

//  Console.WriteLine(formattedLine);

string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);

 var myword="abc";
 System.Console.WriteLine(myword.PadLeft(4));
 string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);


char[] myTest = ['q','v','b'];
// System.Console.WriteLine(string.ToCharCode(myTest)); 
