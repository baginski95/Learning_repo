using static System.Convert;

int a = 10;
double b = a; // Liczbę typu int można zapisać w zmiennej typu double.
WriteLine(b);

double c = 9.8;
int d = (int)c;
WriteLine(d); // W zmiennej d zabraknie ułamka .8.

e = 5_000_000_000;
f = (int)e;
WriteLine($"e ma wartość {e:N0}, a f ma wartość {f:N0}");

double g = 9.8;
int h = ToInt32(g);
WriteLine($"g ma wartość {g}, a h ma wartość {h}");

// Domyślne reguły zaokrąglania

double[] liczby = new[]
  { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

foreach (double n in liczby)
{
  WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

// Kontrolowanie sposobu zaokrąglania

foreach (double n in liczby)
{
  WriteLine(format:
    "Math.Round(value: {0}, digits: 0, mode: MidpointRounding.AwayFromZero) to {1}",
    arg0: n,
    arg1: Math.Round(value: n, digits: 0,
      mode: MidpointRounding.AwayFromZero));
}

// Konwersja z dowolnego typu na ciąg znaków

int liczba = 12;
WriteLine(liczba.ToString());

bool logiczna = true;
WriteLine(logiczna.ToString());

DateTime teraz = DateTime.Now;
WriteLine(teraz.ToString());

object ja = new();
WriteLine(ja.ToString());

// Przygotowanie tablicy 128 bajtów.
byte[] obiektBinarny = new byte[128];

// Wypełnienie tablicy losowymi bajtami.
(new Random()).NextBytes(obiektBinarny);

WriteLine("Binarny obiekt jako bajty: ");
for (int indeks = 0; indeks < obiektBinarny.Length; indeks++)
{
  Write($"{obiektBinarny[indeks]:X} ");
}
WriteLine();

// cKonwersja na ciąg znaków Base64.
string zakodowany = ToBase64String(obiektBinarny);
WriteLine($"Obiekt binarny jako Base64: {zakodowany}");

int wiek = int.Parse("27");
DateTime urodziny = DateTime.Parse("4/6/1980");

WriteLine($"Mam {wiek} lat.");
WriteLine($"Urodziny mam {urodziny}.");
WriteLine($"Urodziny mam {urodziny:D}.");

Write("Ile mamy tutaj jajek? ");
string? dane = ReadLine(); // w notatniku użyj wartości 12

if (int.TryParse(dane, out liczba))
{
  WriteLine($"Mamy {liczba} jajek.");
}
else
{
  WriteLine("Konwersja danych wejściowych się nie powiodła.");
}
