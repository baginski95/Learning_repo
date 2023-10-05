using System.Diagnostics; // Trace
using System.Runtime.CompilerServices; // Atrybuty [Caller...]

partial class Program
{
  static void ProtokolujSzczegoly(
    bool warunek,
    [CallerMemberName] string element = "",
    [CallerFilePath] string sciezka = "",
    [CallerLineNumber] int wiersz = 0,
    [CallerArgumentExpression(nameof(warunek))] string wyrazenie = "")
    {
      Trace.WriteLine(string.Format(
        "[{0}]\n {1} w wierszu {2}. Wyrażenie: {3}",
        sciezka, element, wiersz, wyrazenie));
    }
}
