/*
// wage calculator

static int calculatorYearlyWage(int monthlyWage, int numOfMonthsWorked){
    //Console.WriteLine($"Yearly wage: {monthlyWage * numOfMonthsWorked}");
    return monthlyWage * numOfMonthsWorked;
}

int amount = 1234;
int months = 12;

// Console.WriteLine(calculatorYearlyWage(amount, months));
calculatorYearlyWage(amount, months);
*/
/*
Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
*/

// for (int arr = 1; arr <= 100; arr++)
// {
//     if ((arr % 3 == 0) && (arr % 5 == 0))
//     {
//         Console.WriteLine($"{arr} - FizzBuzz");
//     } else if (arr % 5 == 0)
//     {
//         Console.WriteLine($"{arr} - Buzz");
//     } else if (arr % 3 == 0)
//     {
//         Console.WriteLine($"{arr} - Fizz");
//     } else {
//         Console.WriteLine(arr);
//     }
// }

// int hero = 10;
// int monster = 10;

// Random dice = new();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// string? sumString;

// sumString = Console.ReadLine();

// if (sumString == "strings")
// {
//     Console.WriteLine("This is a string");
// }
// int a = 2;
// string b = "3";
// var result = a + b;

// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"Int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"My decimal: {myDecimal}");

// // string[] pallets = { "B14", "A11", "B12", "A13" };

// //--- Sort, Reverse, Clear, Resize, Split, Join
// string[] pallets = ["B14", "A11", "B12", "A13"]; 
// Console.WriteLine("Sorted...");
// Array.Sort(pallets); /*-- Sorting --*/
// Array.Reverse(pallets); /*-- Resversing --*/
// Array.Clear(pallets, 1, pallets.Length - 1);/*-- Clear --*/
// Array.Resize(ref pallets, 5); /*-- Resize --*/
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// //-- ToCharArray() - Reversing the order of a string...
// string value ="abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = string.Join(" . ", valueArray); //--- Join ---
// Console.WriteLine(result);

// string[] items = result.Split(" . "); // --- Split ---
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] message = pangram.Split(' '); //---- Split and store the string
// string[] newMessage = new string[message.Length];

// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// string results = String.Join(" ", newMessage);
// Console.WriteLine(results);

// Notice in the previous code, the orderStream variable contains a string of multiple Order IDs separated by commas

// Add code below the previous code to parse the "Order IDs" from the string of incoming orders and store the "Order IDs" in an array

// Add code to output each "Order ID" in sorted order and tag orders that aren't exactly four characters in length as "- Error"

// Save and run your code

// The result should look like this:
// A345
// B123
// B177
// B179
// C15     - Error
// C234
// C235
// G3003   - Error

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] orders = orderStream.Split(',');
// Array.Sort(orders);
// foreach(var order in orders)
// {
//     //This is on way to write this
//     // if (order.Length != 4)
//     // {
//     //     Console.WriteLine($"{order}   - Error");
//     // } else {
//     //     Console.WriteLine(order);
//     // }

//     // Another way would be
//     string result = order.Length != 4 ? $"{order} \t- Error" : order;
//     Console.WriteLine(result);
// }