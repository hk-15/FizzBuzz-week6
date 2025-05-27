partial class Program
{
    static string NumberChecker(int num, int divisor, string word)
    {
        if (num % divisor == 0)
        {
            return word;
        }
        return "";
    }

    static string FizzBuzz(int num)
    {
        string result = "";
        result += NumberChecker(num, 3, "Fizz");
        result += NumberChecker(num, 5, "Buzz");
        if (result.Length == 0)
        {
            return num.ToString();
        }
        return result;
    }

    private static void Main(string[] args)
    {
        for (var i = 1; i <= 100; i++)
        {
            string result = "";
            result += FizzBuzz(i);
            Console.WriteLine(result);
        }
    }
}