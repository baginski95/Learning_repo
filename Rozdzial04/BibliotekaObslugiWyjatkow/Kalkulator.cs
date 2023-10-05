using static System.Console;

namespace BibliotekaObslugiWyjatkow
{
  public class Kalkulator
  {
    public static void Gamma() // funkcja publiczna, może być wywoływana z zewnątrz
    {
      WriteLine("W metodzie Gamma");
      Delta();
    }

    private static void Delta() // funkcja prywatna, może być wywoływana tylko wewnętrznie
    {
      WriteLine("W metodzie Delta");
      File.OpenText("nieprawidłowa ścieżka do pliku");
    }
  }
}
