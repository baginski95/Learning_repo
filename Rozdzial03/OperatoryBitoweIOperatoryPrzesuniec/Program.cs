int a = 10; // 00001010
int b = 6;  // 00000110

WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}"); // tylko bit numer 2
WriteLine($"a | b = {a | b}"); // bity numer 8, 4 i 2
WriteLine($"a ^ b = {a ^ b}"); // bity numer 8 i 4

// 0101 0000 przesunięte w lewo o trzy pozycje
WriteLine($"a << 3 = {a << 3}");

// mnożenie razy 8
WriteLine($"a * 8 = {a * 8}");

// 0000 0011 przesunięcie w prawo o jedną pozycję
WriteLine($"b >> 1 = {b >> 1}");

WriteLine();
WriteLine("Wypisuję liczby całkowite w formie binarnej:");
WriteLine($"a     = {NaBinarnyCiagZnakow(a)}");
WriteLine($"b     = {NaBinarnyCiagZnakow(b)}");
WriteLine($"a & b = {NaBinarnyCiagZnakow(a & b)}");
WriteLine($"a | b = {NaBinarnyCiagZnakow(a | b)}");
WriteLine($"a ^ b = {NaBinarnyCiagZnakow(a ^ b)}");

static string NaBinarnyCiagZnakow(int liczba)
{
  return Convert.ToString(liczba, toBase: 2).PadLeft(8, '0');
}

