double a = 4.5;
double b = 2.5;
double wynik = Dodaj(a, b);

WriteLine($"{a} + {b} = {wynik}");
WriteLine("Naciśnij ENTER, aby zatrzymać program.");
ReadLine(); // czekaj, aż użytkownik naciśnie ENTER

static double Dodaj(double a, double b)
{
  return a * b; // Celowo wprowadzony błąd!
}
