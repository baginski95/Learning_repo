using static System.Console;
using static System.Convert;


static void OpenFile()
{
    string path = @"C:\Users\bagic\OneDrive\Pulpit";

    Write("Press R for read-only or W for writeable: ");
    ConsoleKeyInfo key = ReadKey();
    WriteLine();

    Stream? s;

    if (key.Key == ConsoleKey.R)
    {
        s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read);
    }
    else
    {
        s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write);
    }

    string message;

    switch (s)
    {
        case FileStream writeableFile when s.CanWrite:
            message = "The stream is a file that I can write to.";
            break;
        case FileStream readOnlyFile:
            message = "The stream is a read-only file.";
            break;
        case MemoryStream ms:
            message = "The stream is a memory address.";
            break;
        default: // always evaluated last despite its current position
            message = "The stream is some other type.";
            break;
        case null:
            message = "The stream is null.";
            break;
    }

     WriteLine(message);
}

static long Factorial(long number)
{
    if (number < 1)
    {
    return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked
        {
            return number * Factorial(number - 1);
        }
    }
}

static void RunFactorial(long number)
{
    for (int i = 1; i <= number; i++)
    {
        try
        {
            WriteLine($"{i}! = {Factorial(i):N0}");
        }
        catch(System.StackOverflowException)
        {
            WriteLine($"{i}! is too big for a 64-bit integer.");
        }
        
    }
}

static int FibImperative(int term)
{
    if (term == 1)
    {
        return 0;
    }
    else if (term == 2)
    {
        return 1;
    }
    else
    {
        return FibImperative(term - 1) + FibImperative(term - 2);
    }
}

static string CardinalToOrdinal(int number)
{
    switch (number)
    {
        case 11: // special cases for 11th to 13th
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}

static void RunFibImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
        arg0: CardinalToOrdinal(i),
        arg1: FibImperative(term: i));
    }
}

//RunFactorial(10);
RunFibImperative();

