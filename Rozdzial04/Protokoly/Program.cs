using System.Diagnostics;
using Microsoft.Extensions.Configuration;

string sciezka = Path.Combine(Environment.GetFolderPath(
    Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine($"Zapisuję do pliku: {sciezka}");

TextWriterTraceListener plikProtokolu = new(File.CreateText(sciezka));

Trace.Listeners.Add(plikProtokolu);

// Zapisywanie tekstu jest buforowane, a ta opcja wywołuje
// metodę Flush() we wszystkich obiektach nasłuchujących
// po wykonaniu każdego zapisu.
Trace.AutoFlush = true;

Debug.WriteLine("Typ Debug mówi, że już jest gotowy!");
Trace.WriteLine("Typ Trace mówi, że już jest gotowy!");

Console.WriteLine("Odczytywanie konfiguracji z pliku appsettings.json z folderu {0}",
  arg0: Directory.GetCurrentDirectory());

ConfigurationBuilder tworcaKonfiguracji = new();

tworcaKonfiguracji.SetBasePath(Directory.GetCurrentDirectory());
tworcaKonfiguracji.AddJsonFile("appsettings.json",
    optional: true, reloadOnChange: true);

IConfigurationRoot konfiguracja = tworcaKonfiguracji.Build();

TraceSwitch ts = new(
  displayName: "Przelacznik",
  description: "Ten przełącznik jest ustawiany przez konfigurację z pliku JSON.");

konfiguracja.GetSection("Przelacznik").Bind(ts);

Trace.WriteLineIf(ts.TraceError, "Poziom błędów");
Trace.WriteLineIf(ts.TraceWarning, "Poziom ostrzeżeń");
Trace.WriteLineIf(ts.TraceInfo, "Poziom informacji");
Trace.WriteLineIf(ts.TraceVerbose, "Poziom ogólny");

int liczbaSztuk = 12;
ProtokolujSzczegoly(liczbaStuk > 10);

Console.ReadLine();
