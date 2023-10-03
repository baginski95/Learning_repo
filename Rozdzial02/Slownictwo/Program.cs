using System.Reflection;

// zadeklaruj kilka nieużywanych zmiennych, używając typów
// z dodatkowych zestawów
System.Data.DataSet ds;
HttpClient client;

Assembly? zestaw = Assembly.GetEntryAssembly();

if (zestaw == null) return;  // zamknięcie aplikacji

// przeglądaj w pęli zestawy używane przez tę aplikację
foreach (AssemblyName nazwa in zestaw.GetReferencedAssemblies())
{
  // załaduj zestaw, aby odczytać szczegółowe dane na jego temat
  Assembly a = Assembly.Load(nazwa);

  // zadeklaruj zmienną zliczającą metody
  int liczbaMetod = 0;

  // przeglądaj w pętli wszystkie typy z zestawu
  foreach (TypeInfo t in a.DefinedTypes)
  {
    // dodaj liczbę metody
    liczbaMetod += t.GetMethods().Count();
  }

  // Wypisz liczbę typów oraz ich metod
  Console.WriteLine(
    "W zestawie {2} jest {0:N0} typów oraz {1:N0} metod.",
    arg0: a.DefinedTypes.Count(),
    arg1: liczbaMetod, arg2: nazwa.Name);
}