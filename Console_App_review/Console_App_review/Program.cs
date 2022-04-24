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

RunFactorial(10);

