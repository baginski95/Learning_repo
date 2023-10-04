// pętla z instrukcję while

int x = 0;

while (x < 10)
{
  WriteLine(x);
  x++;
}

// Pętla z instrukcją do
string? faktyczneHaslo = "sekret";
string? haslo;
int maksymalnaLiczbaProb = 10;
int liczbaProb = 0;

do
{
  liczbaProb++;
  Write("Podaj swoje hasło: ");
  haslo = ReadLine();
}
while ((haslo != faktyczneHaslo) & (liczbaProb < maksymalnaLiczbaProb));

if (liczbaProb < maksymalnaLiczbaProb)
{
  WriteLine("Tak jest!!");
}
else
{
  WriteLine("Wykorzystano już {0} prób! Hasło to {1}",
    arg0: maksymalnaLiczbaProb,
	arg1: faktyczneHaslo);
}

// Pętla z instrukcją for

for (int y = 1; y <= 10; y++)
{
  WriteLine(y);
}

// Pętla z instrukcją foreach

string[] imiona = { "Maria", "Bartek", "Dariusz" };

foreach (string imie in imiona)
{
  WriteLine($"{imie} ma {imie.Length} znaków.");
}
