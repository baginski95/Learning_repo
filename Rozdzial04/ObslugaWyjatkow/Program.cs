using BibliotekaObslugiWyjatkow;
using static System.Console;

WriteLine("W metodzie Main");
Alfa();

void Alfa()
{
  WriteLine("W metodzie Alfa");
  Beta();
}

void Beta()
{
  WriteLine("W metodzie Beta");
  Kalkulator.Gamma();
}
