Random random = new Random();
int luck = random.Next(100);

string[] text = ["You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"];
string[] good = ["look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"];
string[] bad = ["fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."];
string[] neutral = ["appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."];

Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}

// Update the code to use a method to display the fortune.

// Use what you've learned about creating and calling methods to complete the update.

// Test your code by changing the value of luck and calling the method again.

// Verify that your code produces one of the following messages:

//A fortune teller whispers the following words:
//You have much to look forward to. Today is a day to try new things! Whatever work you do is likely to succeed. This is an ideal time to accomplish your dreams!

string[] words = ["racecar" ,"talented", "deified", "tent", "tenet"];

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words) 
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }