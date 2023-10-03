using System.Xml;

object wysokosc = 1.88; // zapisanie wartości typu double
object imie = "Amir"; // zapisanie wartości typu string
Console.WriteLine($"{imie} is {height} metres tall.");

//int dlugosc1 = imie.Length; // powoduje błąd kompilacji!
int dlugosc2 = ((string)imie).Length; // poinformuj kompilator, że pracuje z typem string
Console.WriteLine($"{imie} ma {dlugosc2} znaków.");

// przechowywanie wartości typu string w zmiennej typu dynamic
// typ string ma właściwość Length
dynamic cos = "Ahmed";

// typ int nie ma właściwości Length
// cos = 12;

// Tablica dowolnego typu ma właściwość Length
// cos = new[] { 3, 5, 7 }

// tę instrukcję można skompilować, ale może ona powodować błędy w czasie pracy programu,
// jeżeli wartość zapisana w zmiennej nie ma właściwości o nazwie Length!
int dlugosc = cos.Length;

int populacja = 38_000_000; // 38 mln ludzi w Polsce
double waga = 1.88; // w kilogramach
decimal cena = 4.99M; // w złotówkach
string owoce = "jabłka"; // ciąg znaków w cudzysłowie
char litera = 'Z'; // znaki umieszczamy między apostrofami
bool radosc = true; // typ bool przyjmuje wartości true lub false

// dobre użycie słowa kluczowego var, ponieważ unikamy w nim
// niepotrzebnego powtórzenia typu, tak jak w dłuższej, drugiej instrukcji.
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// złe użycie słowa kluczowego var, ponieważ nie da się łatwo określić typu zmiennej.
// Lepiej jest jawnie podać typ, tak jak w drugiej instrukcji.
var plik1 = File.CreateText(@"C:\plik.txt");
StreamWriter plik2 = File.CreateText(@"C:\plik.txt");

XmlDocument xml3 = new(); //new o typie docelowym z języka C# 9

// klasa Osoba jest definiowana na końcu tego pliku
Osoba piotr = new();
piotr.DataUrodzenia = new(1967, 12, 26); // zamiast instrukcji: new DateTime(1967, 12, 26)


Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine(
  $"default(DateTime) = {default(DateTime)}");
Console.WriteLine(
  $"default(string) = {default(string)}");

int liczba = 13;
Console.WriteLine($"Zmienna liczba ma wartość: {liczba}");
liczba = default;
Console.WriteLine($"Zmienna liczba ma domyślną wartość: {liczba}");