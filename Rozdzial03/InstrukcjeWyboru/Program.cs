string haslo = "ninja";

if (haslo.Length < 8)
{
  WriteLine("Twoje hasło jest za krótkie. Musi mieć przynajmniej 8 znaków.");
}
else
{
  WriteLine("Masz silne hasło.");
}

// Dodanie lub usunięcie cudzysłowu zmieni zachowanie tego kodu.
object o = 3;
int j = 4;

if (o is int i)
{
  WriteLine($"{i} x {j} = {i * j}");
}
else
{
  WriteLine("o nie ma typu int, a zatem nie mogę wykonać mnożenia!");
}

int liczba = (new Random()).Next(1, 7);
WriteLine($"Wylosowano liczbę {liczba}");

switch (liczba)
{
  case 1:
        WriteLine("Jeden");
        break; // Skacze na koniec instrukcji switch.
     case 2:
        WriteLine("Dwa");
        goto case 1;
     case 3: // Sekcja obsługująca wiele przypadków.
     case 4:
        WriteLine("Trzy lub cztery");
        goto case 1;
     case 5:
		// wstrzymanie na pół sekundy
		System.Threading.Thread.Sleep(500);
        goto Etykieta;
     default:
        WriteLine("Domyślnie");
        break;
  } // Koniec instrukcji switch.

WriteLine("Koniec instrukcji switch.");
Etykieta:
WriteLine("Już za etykietą.");

// Dopasowywanie wzorców z instrukcją switch

Zwierze?[] zwierzeta = new Zwierze?[]
{
  new Kot { Imie = "Karen", Born = new(year: 2022, month: 8, day: 23),
    Nogi = 4, JestUdomowione = true },
  null,
  new Kot { Imie = "Mufasa", Born = new(year: 1994, month: 6, day: 12) },
  new Pajak { Imie = "Paskuda", Born = DateTime.Today,
    JestJadowite = true},
  new Pajak { Imie = "Włochatek", Born = DateTime.Today }
};

foreach (Zwierze? zwierze in zwierzeta)
{
  string komunikat;
  switch (zwierze)
  {
    case Kot kotCzworonozny when kotCzworonozny.Nogi == 4:
      komunikat = $"Kot o imieniu {kotCzworonozny.Imie} ma cztery łapy.";
      break;
    case Cat dzikiKot when dzikiKot.JestUdomowione == false:
      komunikat = $"Ten dziki kot ma na imię {dzikiKot.Imie}.";
      break;
    case Kot kot:
      komunikat = $"Kot ma na imię{kot.Imie}.";
      break;
    default: // Domyślny wariant jest używany na końcu
      komunikat = $"Zwierzę o imieniu {zwierze.Imie} to {zwierze.GetType().Name}.";
      break;
    case Pajak pajakwhen pajak.JestJadowite:
      komunikat = $"Pająk {pajak.Imie} jest jadowity. Uciekaj!";
      break;
    case null:
      message = "To zwierze ma wartość null.";
      break;
  }
  WriteLine($"Instrukcja switch: {komunikat}");
}

komunikat = zwierze switch
{
  Kot kotCzworonozny when kotCzworonozy.Nogi == 4
    => $"Kot o imieniu {kotCzworonozny.Imie} ma cztery łapy.",
  Kott dzikiKot when dzikiKot.JestUdomowione == false
    => $"Ten dziki kot ma na imię {dzikiKot.Imie}.",
  Kot kot
    => $"Kot ma na imię{kot.Imie}.",
  Pajak pajak when pajak.JestJadowite
    => $"Pająk {pajak.Imie} jest jadowity. Uciekaj!",
  null
    => "To zwierze ma wartość null.",
  _
    => $"Zwierzę o imieniu {zwierze.Imie} to {zwierze.GetType().Name}."
};
WriteLine($"Wyrażenie switch: {komunikat}");



// string sciezka = "/Users/markjprice/Kod/Rozdzial03";
string sciezka = @"C:\Kod\Rozdzial03";

Write("Wybierz: O dla odczytu albo Z dla zapisu: ");
ConsoleKeyInfo klawisz = ReadKey();
WriteLine();

Stream? s;

if (klawisz.Key == ConsoleKey.R)
{
  s = File.Open(
    Path.Combine(sciezka, "plik.txt"),
    FileMode.OpenOrCreate,
    FileAccess.Read);
}
else
{
  s = File.Open(
    Path.Combine(sciezka, "plik.txt"),
    FileMode.OpenOrCreate,
    FileAccess.Write);
}

string komunikat;

switch (s)
{
  case FileStream plikDoZapisu when s.CanWrite:
      komunikat = "Strumień prowadzi do pliku, do którego mogę pisać.";
      break;
   case FileStream plikTylkoDoOdczytu:
      komunikat = "Strumień prowadzi do pliku tylko do odczytu.";
      break;
   case MemoryStream ms:
      komunikat = "Strumień prowadzi do adresu w pamięci.";
      break;
   default: // zawsze sprawdzany na końcu, niezależnie od pozycji w kodzie
      komunikat = "To strumień innego typu.";
      break;
   case null:
      komunikat = "Strumień ma wartość null.";
    break;
}

WriteLine(komunikat);

komunikat = s switch
{
  FileStream plikDoZapisu when s.CanWrite
    => " Strumień prowadzi do pliku, do którego mogę pisać.",
  FileStream plikTylkoDoOdczytu
    => " Strumień prowadzi do pliku tylko do odczytu.",
  MemoryStream ms
    => "Strumień prowadzi do adresu w pamięci.",
  null
    => "Strumień ma wartość null.",
  _
    => "To strumień innego typu."
};

WriteLine(komunikat);
