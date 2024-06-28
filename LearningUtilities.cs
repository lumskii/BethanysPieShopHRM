/*
// wage calculator
using BethanysPieShopHRM;

int amount = 1234;
int months = 11;
int bonus = 1000;

// Console.WriteLine(calculatorYearlyWage(amount, months));
int yearlyWage = Utilities.CalculatorYearlyWage(amount, months, bonus);

Console.WriteLine($"Yearly wage: {yearlyWage}");

// Console.ReadLine();

Random dice = new();

int roll = dice.Next(1, 7);

Console.WriteLine(roll);
*/

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// } else if (daysUntilExpiration <= 5 && daysUntilExpiration > 2)
// {
//     discountPercentage = 10;
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
// } else if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
//     Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
// } else if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }

// Random coin = new();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");
// Console.WriteLine(flip);

// int amount = 50;
// int bonus = amount >= 100? 10: 5;

// Console.WriteLine(bonus);

// decimal myDecimal = 3.5m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// //---String to int---
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// string value1 = "5";
// string value2 = "7";

// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// string myInput = "2.27";
// decimal.TryParse(myInput, out decimal myInputDecimal);

// Console.WriteLine(myInputDecimal);

// //--- CHALLANGE 1---
// string[] values = ["12.3", "45", "ABC", "11", "DEF"];

// decimal result = 0; 

// string alpha = "";

// for(int i = 0; i < values.Length; i++){
//     var sum = values[i];
//     if (decimal.TryParse(sum, out decimal item))
//     {
//         result += item;
//     } else {
//         alpha += sum;
//     }
// }

// Console.WriteLine($"Message: {alpha}");
// Console.WriteLine("Total: " + result);

// //--- CHALLANGE 2---
// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// int result1 = Convert.ToInt32(value1 / value2);
// // Hint: You need to round the result to nearest integer (don't just truncate)
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// decimal result2 = value2 / (decimal) value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");