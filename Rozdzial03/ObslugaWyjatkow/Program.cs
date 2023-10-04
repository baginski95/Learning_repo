WriteLine("Przed parsowaniem");
Write("Ile masz lat? ");
string? dane = ReadLine(); // w notatniku przypisz wartość "49"

try
{
  int wiek = int.Parse(dane);
  WriteLine($"Masz już {wiek} lat.");
}
catch (OverflowException)
{
  WriteLine("Podany wiek jest liczbą, ale jest ona za duża albo za mała.");
}
catch (FormatException)
{
  WriteLine("Podany wiek nie jest liczbą.");
}
catch (Exception ex)
{
  WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("Parsowanie zakończone");

Write("Podaj kwotę: ");
string? kwota = ReadLine();
try
{
  decimal wartoscKwoty = decimal.Parse(kwota);
}
catch (FormatException) when (kwota.Contains("$"))
{
  WriteLine("Kwota nie może zawierać znaku dolara!");
}
catch (FormatException)
{
  WriteLine("Kwota może składać się wyłącznie z cyfr!");
}
