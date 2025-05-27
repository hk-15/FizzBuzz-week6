string NumberChecker(int num, int divisor, string word, string rules)
{
    if (num % divisor == 0 && rules.Contains(word))
    {
        return word;
    }
    return "";
}

string FizzBuzz(int num, string rules)
{
    string result = "";
    if (num % 17 == 0 && rules.Contains("Reverse"))
    {
        if (num % 11 == 0)
        {
            result += NumberChecker(num, 11, "Bong", rules);
            result += NumberChecker(num, 13, "Fezz", rules); 
            
        }
        else
        {
            result += NumberChecker(num, 7, "Bang", rules);
            result += NumberChecker(num, 5, "Buzz", rules);
            result += NumberChecker(num, 13, "Fezz", rules);
            result += NumberChecker(num, 3, "Fizz", rules);
        }
        
    }
    else
    {
        if (num % 11 == 0)
        {
            result += NumberChecker(num, 13, "Fezz", rules);
            result += NumberChecker(num, 11, "Bong", rules);
        }
        else
        {
            result += NumberChecker(num, 3, "Fizz", rules);
            result += NumberChecker(num, 13, "Fezz", rules);
            result += NumberChecker(num, 5, "Buzz", rules);
            result += NumberChecker(num, 7, "Bang", rules);
        
        }
    }

    if (result.Length == 0)
    {
        return num.ToString();
    }
    return result;
}

int numInput;
Console.WriteLine("To run FizzBuzz, please provide a maximum number:");
bool isNumInputValid = int.TryParse(Console.ReadLine(), out numInput);
while (!isNumInputValid)
{
    Console.WriteLine("Please enter a valid number.");
    Console.WriteLine("To run FizzBuzz, please provide a maximum number:");
    isNumInputValid = int.TryParse(Console.ReadLine(), out numInput);
}

string finalRules = "";
string fizz = "Fizz";
string buzz = "Buzz";
string bang = "Bang";
string bong = "Bong";
string fezz = "Fezz";
string reverse = "Reverse";

Console.WriteLine("And now which rules would you like to implement?");
Console.WriteLine("Press 1 to include the rule or any other key to skip it.");
Console.WriteLine("");

string rulesChecker(string num, string rule)
{
    if (num == "1")
    {
        return rule + " ";
    }
    return "";
}

Console.WriteLine($"Fizz for multiples of 3?");
var rulesInput = Console.ReadLine();
if (rulesInput != null)
{
    finalRules += rulesChecker(rulesInput, fizz);
}

Console.WriteLine($"Buzz for multiples of 5?");
rulesInput = Console.ReadLine();
if (rulesInput != null)
{
    finalRules += rulesChecker(rulesInput, buzz);
}

Console.WriteLine($"Bang for multiples of 7?");
rulesInput = Console.ReadLine();
if (rulesInput != null)
{
    finalRules += rulesChecker(rulesInput, bang);
}

Console.WriteLine($"Bong for multiples of 11?");
rulesInput = Console.ReadLine();
if (rulesInput != null)
{
    finalRules += rulesChecker(rulesInput, bong);
}

Console.WriteLine($"Fezz for multiples of 13?");
rulesInput = Console.ReadLine();
if (rulesInput != null)
{
  finalRules += rulesChecker(rulesInput, fezz);  
}

Console.WriteLine($"Reverse words for multiples of 17?");
rulesInput = Console.ReadLine();
if (rulesInput != null)
{
   finalRules += rulesChecker(rulesInput, reverse); 
}
Console.WriteLine(finalRules);
Console.WriteLine("OK, here we go. Preparing to FizzBuzz");
Console.WriteLine(". . .");

for (var i = 1; i <= numInput; i++)
{
    string result = "";
    result += FizzBuzz(i, finalRules);
    Console.WriteLine(result);
}