// wage calculator
using BethanysPieShopHRM;

int amount = 1234;
int months = 11;
int bonus = 1000;

// Console.WriteLine(calculatorYearlyWage(amount, months));
int yearlyWage = Utilities.CalculatorYearlyWage(amount, months, bonus);

Console.WriteLine($"Yearly wage: {yearlyWage}");

Console.ReadLine();