partial class Program
{
   static void TabliczkaMnozenia(byte liczba, byte wielkosc = 12)
  {
    WriteLine($"To jest sekwencja mnożenia {wielkosc} liczb przez {liczba}.");
    for (int wiersz = 1; wiersz <= wielkosc; wiersz++)
    {
      WriteLine($"{wiersz} x {liczba} = {wiersz * liczba}");
    }
  }


  static decimal PodatekVAT(decimal kwota, string kodRegionu)
{
   decimal stawka = 0.0M;

   // Porównujemy tutaj wartości typu string
   // dlatego lepiej jest użyć instrukcji switch
   // a nie wyrażenia switch

   switch (kodRegionu)
   {
      case "CH": // Szwajcaria
         stawka = 0.08M;
         break;
      case "DK": // Dania
      case "NO": // Norwegia
         stawka = 0.25M;
         break;
      case "GB": // Wielka Brytania
      case "FR": // Francja
         stawka = 0.2M;
         break;
      case "HU": // Węgry
         stawka = 0.27M;
         break;
      case "OR": // Oregon
      case "AK": // Alaska
      case "MT": // Montana
         stawka = 0.0M;
         break;
      case "ND": // Dakota Północna
      case "WI": // Wisconsin
      case "ME": // Maryland
      case "VA": // Wirginia
         stawka = 0.05M;
         break;
      case "CA": // Kalifornia
         stawka = 0.0825M;
         break;
      default: // Polska
         stawka = 0.23M;
         break;
   }
   return kwota * stawka;
}
  
   /// <summary>
   /// Przyjmuje liczbę 32-bitową i wypisuje dla niej angielski liczebnik porządkowy.
   /// </summary>
   /// <param name="liczba">Liczba można traktować jak liczebnik głównym taki jak 1, 2, 3 itd.</param>
   /// <returns>Zwracany ciąg znaków jest angielskim liczebnikiem porządkowym: 1st, 2nd, 3rd itd.</returns>
   static string GlowneNaPorzadkowe(int liczba)
   {
      int dwieOstatnieCyfry = liczba % 100;

      switch (dwieOstatnieCyfry)
      {
         case 11:  // Przypadki specjalne dla liczb 11, 12 i 13.
         case 12:
         case 13:
            return $"{liczba}th";
         default:
            int ostatniaCyfra = liczba % 10;

            string przyrostek = ostatniaCyfra switch
            {
               1 => "st",
               2 => "nd",
               3 => "rd",
               _ => "th"
            };
            return $"{liczba}{przyrostek}";
      }
   }

  static void ZmienGlowneNaPorzadkowe()
{
   for (int liczba = 1; liczba <= 40; liczba++)
   {
      Write($"{GlowneNaPorzadkowe(liczba)} ");
   }
   WriteLine();
}

  static int Silnia(int liczba)
{
   if (liczba < 1)
   {
      throw new ArgumentException(
       message: "Obliczenie silni jest możliwe tylko dla dodatnich liczb całkowitych.",
       paramName: "liczba");
   }
   else if (liczba == 0)
   {
      return 1;
   }
   else
   {
      checked  // zabezpieczenie przed przepełnieniem
      {
         return liczba * Silnia(liczba - 1);
      }
   }
}


static void ObliczSilnie()
{
   for (int i = 1; i < 15; i++)
   {
      try
      {
         WriteLine($"{i}! = {Silnia(i):N0}");
      }
      catch (System.OverflowException)
      {
         WriteLine($"{i}! jest zbyt wielka dla 32-bitowej zmiennej.");
      }
   }
}

static int FibImperatywna(int pozycja)
{
   if (pozycja == 1)
   {
      return 0;
   }
   else if (pozycja == 2)
   {
      return 1;
   }
   else
   {
      return FibImperatywna(pozycja - 1) + FibImperatywna(pozycja - 2);
   }
}

static void UruchomFibImperatywna()
{
   for (int i = 1; i <= 30; i++)
   {
      WriteLine("{0}. pozycja w ciągu Fibonacciego to {1:N0}.",
        arg0: i,
        arg1: FibImperatywna(pozycja: i));
   }
}

static int FibFunkcyjna(int pozycja) =>
pozycja switch
{
   1 => 0,
   2 => 1,
   _ => FibFunkcyjna(pozycja - 1) + FibFunkcyjna(pozycja - 2)
};

static void UruchomFibFunkcyjna()
{
   for (int i = 1; i <= 30; i++)
   {
      WriteLine("{0}. pozycja w ciągu Fibonacciego to {1:N0}.",
        arg0: i,
        arg1: FibFunkcyjna(pozycja: i));
   }
}

}
