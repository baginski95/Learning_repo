WriteLine($"Otrzymano {args.Length} argumentów.");

foreach (string arg in args)
{
  WriteLine(arg);
}

if (args.Length < 3)
{
  WriteLine("Musisz podać dwa kolory oraz wymiary okna, np.:");
  WriteLine("dotnet run red yellow 80 40");
  return; // Zakończ pracę.
}

ForegroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor),
  value: args[0],
  ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor),
  value: args[1],
  ignoreCase: true);

try
{
  CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
  WriteLine("Aktualna platforma nie pozwala na zmianę wielkości kursora.");
}