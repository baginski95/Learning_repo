using BibliotekaKalkulator;

namespace BibliotekaKalkulatorTesty
{
  public class KalkulatorTesty
  {
    [Fact]
    public void TestDodaj2i2()
    {
      // przygotuj
      double a = 2;
      double b = 2;
      double oczekiwane = 4;
      Kalkulator kal = new();

      // wykonaj
      double wynik = kal.Dodaj(a, b);

      // sprawdź
      Assert.Equal(oczekiwane, wynik);
    }

    [Fact]
    public void TestDodaj2i3()
    {
      // przygotuj
      double a = 2;
      double b = 3;
      double oczekiwane = 5;
      Kalkulator kal = new();

      // wykonaj
      double wynik = kal.Dodaj(a, b);

      // sprawdź
      Assert.Equal(oczekiwane, wynik);
    }
  }
}