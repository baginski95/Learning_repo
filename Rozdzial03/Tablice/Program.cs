string[] imiona; // Może przechowywać dowolną tablicę ciągów znaków.

// Rezerwowanie pamięci na tablicę czteroelementową.
imiona = new string[4];

// Zapisywanie imion pod różnymi indeksami
imiona[0] = "Kasia";
imiona[1] = "Jacek";
imiona[2] = "Joasia";
imiona[3] = "Tomek";

string[] imiona2 = new[] { "Kasia", "Jacek", "Joasia", "Tomek" };

// Przeglądanie w pętli wszystkich imion.
for (int i = 0; i < imiona.Length; i++)
{
  // Wypisanie wartości pod indeksem i.
  Console.WriteLine(imiona[i]); 
}

string[,] tablica1 = new[,] // dwa wymiary
{
  { "Alfa", "Beta", "Gamma", "Delta" },
  { "Anna", "Bartek", "Celina", "Darek" },
  { "Aksolotl", "Borsuk", "Chomik", "Delfin" }
};

WriteLine($"Dolna granica pierwszego wymiaru to: {tablica1.GetLowerBound(0)}");
WriteLine($"Górna granica pierwszego wymiaru to: {tablica1.GetUpperBound(0)}");
WriteLine($"Dolna granica drugiego wymiaru to: {tablica1.GetLowerBound(1)}");
WriteLine($"Górna granica drugiego wymiaru to: {tablica1.GetUpperBound(1)}");


for (int wiersz = 0; wiersz <= tablica1.GetUpperBound(0); wiersz++)
{
  for (int kolumna = 0; kolumna <= tablica1.GetUpperBound(1); kolumna++)
  {
    WriteLine($"Wiersz {wiersz}, Kolumna {kolumna}: {tablica1[wiersz, kolumna]}");
  }
}

// inna składnia
string[,] tablica2 = new string[3,4]; // rezerwowanie pamięci
tablica2[0, 0] = "Alfa"; // przypisywanie wartości
tablica2[0, 1] = "Beta";
// i tak dalej...
tablica2[2, 3] = "Delfin";


string[][] poszarpana = new[] // tablica tablic z elementami typu string
{
  new[] { "Alfa", "Beta", "Gamma" },
  new[] { "Anna", "Bartek", "Celina", "Darek" },
  new[] { "Aksolotl", "Borsuk" }
};

WriteLine("Górna granica tablicy tablic to: {0}",
    poszarpana.GetUpperBound(0));

for (int tablica = 0; tablica <= poszarpana.GetUpperBound(0); tablica++)
{
  WriteLine("Górna granica tablicy {0} to: {1}",
    arg0: tablica,
    arg1: poszarpana[tablica].GetUpperBound(0));
}

for (int wiersz = 0; wiersz <= poszarpana.GetUpperBound(0); wiersz++)
{
  for (int kolumna = 0;  kolumna <= poszarpana[wiersz].GetUpperBound(0); kolumna++)
  {
    WriteLine($"Wiersz {wiersz}, Kolumna {kolumna}: {poszarpana[wiersz][kolumna]}");
  }
}

// dopasowywanie wzorców z tablicami

int[] kolejneLiczby = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] liczbyJedenDwa = new int[] { 1, 2 };
int[] liczbyJedenDwaDziesiec= new int[] { 1, 2, 10 };
int[] liczbyJedenDwaTrzyDziesiec = new int[] { 1, 2, 3, 10 };
int[] liczbyPierwsze = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] liczbyFibonacciego = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] pustaLista = new int[] { };
int[] trzyLiczby = new int[] { 9, 7, 5 };
int[] szescLiczb = new int[] { 9, 7, 5, 4, 2, 10 };

WriteLine($"{nameof(kolejneLiczby)}:
{ Dopasuj(kolejneLiczby)}");
WriteLine($"{nameof(liczbyJedenDwa)}: { Dopasuj(liczbyJedenDwa)}");
WriteLine($"{nameof(liczbyJedenDwaDziesiec)}:
{ Dopasuj(liczbyJedenDwaDziesiec)}");
WriteLine($"{nameof(liczbyJedenDwaTrzyDziesiec)}:
{ Dopasuj(liczbyJedenDwaTrzyDziesiec)}");
WriteLine($"{nameof(liczbyPierwsze)}: { Dopasuj(liczbyPierwsze)}");
WriteLine($"{nameof(liczbyFibonacciego)}:
{ Dopasuj(liczbyFibonacciego)}");
WriteLine($"{nameof(pustaLista)}: { Dopasuj(pustaLista)}");
WriteLine($"{nameof(trzyLiczby)}: { Dopasuj(trzyLiczby)}");
WriteLine($"{nameof(szescLiczb)}: { Dopasuj(szescLiczb)}");

static string Dopasuj(int[] wartosci) => wartosci switch
{
  [] => "Pusta tablica",
  [1, 2, _, 10] => "Zawiera 1, 2, dowolną inną liczbę, 10.",
  [1, 2, .., 10] => "Zawiera 1, 2, dowolny zbiór innych liczb, 10.",
  [1, 2] => "Zawiera 1, a po niej 2.",
  [int elem1, int elem2, int elem3] => $"Zawiera {elem1}, potem {elem2}, potem {elem3}.",
  [0, _] => "Zaczyna się od 0, a potem jest jedna liczba.",
  [0, ..] => "Zaczyna się od 0, a potem kolejne liczby.",
  [2, .. int[] inne] => $"Zaczyna się od 2, a potem zawiera {inne.Length} innych liczb.",
  [..] => "Dowolna liczba elementów w dowolnej kolejności.",
};
