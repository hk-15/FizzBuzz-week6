string NumberChecker(int num, int divisor, string word)
{
    if (num % divisor == 0)
    {
        return word;
    }
    return "";
}

string FizzBuzz(int num)
{
    string result = "";
    if (num % 17 == 0)
    {
        if (num % 11 == 0)
        {
            result += NumberChecker(num, 11, "Bong");
            result += NumberChecker(num, 13, "Fezz");
        }
        else
        {
            result += NumberChecker(num, 7, "Bang");
            result += NumberChecker(num, 5, "Buzz");
            result += NumberChecker(num, 13, "Fezz");
            result += NumberChecker(num, 3, "Fizz");
        }
    }
    else
    {
        if (num % 11 == 0)
        {
            result += NumberChecker(num, 13, "Fezz");
            result += NumberChecker(num, 11, "Bong");
        }
        else
        {
            result += NumberChecker(num, 3, "Fizz");
            result += NumberChecker(num, 13, "Fezz");
            result += NumberChecker(num, 5, "Buzz");
            result += NumberChecker(num, 7, "Bang");
        }
    }

    if (result.Length == 0)
    {
        return num.ToString();
    }
    return result;
}

int input;

Console.WriteLine("To run FizzBuzz, please provide a maximum number:");
bool isInputValid = int.TryParse(Console.ReadLine(), out input);

while (!isInputValid)
{
    Console.WriteLine("Please enter a valid number.");
    Console.WriteLine("To run FizzBuzz, please provide a maximum number:");
    isInputValid = int.TryParse(Console.ReadLine(), out input);
}

for (var i = 1; i <= input; i++)
{
    string result = "";
    result += FizzBuzz(i);
    Console.WriteLine(result);
}