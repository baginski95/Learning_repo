int liczbaJablek = 12;
decimal cenaJablka = 0.35M;

WriteLine(
    format: "{0} jabłek kosztuje {1:C}",
    arg0: liczbaJablek,
    arg1: cenaJablka * liczbaJablek);

string sformatowane = string.Format(
    format: "{0} jabłek kosztuje {1:C}",
    arg0: liczbaJablek,
    arg1: cenaJablka * liczbaJablek);

//ZapiszDoPliku(sformatowane); // Zapisuje ciąg znaków do pliku

WriteLine($"{liczbaJablek} jabłek kosztuje {cenaJablka * liczbaJablek:C}");

Write("Wpisz swoje imię i naciśnij ENTER: ");
string? imie = ReadLine();

Write("Podaj swój wiek i nciścnij ENTER: ");
string? wiek = ReadLine();

WriteLine(
  $"Cześć {imie}, dobrze wyglądasz jak na {wiek} lat.");

Write("Naciśnij dowolną kombinację klawiszy: ");
ConsoleKeyInfo klawisz = ReadKey();
WriteLine();
WriteLine("Klawisz: {0}, Znak: {1}, Modyfiktory: {2}",
  arg0: klawisz.Key,
  arg1: klawisz.KeyChar,
  arg2: klawisz.Modifiers);
