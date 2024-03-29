﻿// liczba całkowita bez znaku może być wyłącznie dodatnia lub może być zerem
uint liczbaCalkowita = 23;

// liczba całkowita ze znakiem może być dodatnia i ujemna lub może być zerem
int liczbaCalkowitaZeZnakiem = -23;

// float oznacza liczbę zmiennoprzecinkową o pojedynczej precyzji
// Przyrostek F sprawia, że literał jest obsługiwany z typem float.
float liczbaRzeczywista = 2.3F;

// double oznacza liczbę zmiennoprzecinkową o podwójnej precyzji
double innaLiczbaRzeczywista = 2.3;   // literał liczby typu double

// Trzy zmienne przechowujące wartość 2 miliony.
int notacjaDziesietna = 2_000_000;
int notacjaBinarna = 0b_0001_1110_1000_0100_1000_0000;
int notacjaSzesnastkowa = 0x_001E_8480;

// Sprawdzenie, czy te trzy zmienne przechowują tę samą wartość.
// Obie instrukcje wypisują „true”.
Console.WriteLine($"{notacjaDziesietna == notacjaBinarna}");
Console.WriteLine($"{notacjaDziesietna == notacjaSzesnastkowa}");

//-------------------------------------------
Console.WriteLine($"Typ int zajmuje {sizeof(int)} bajtów i może przechowywać liczby z zakresu od { int.MinValue:N0} do { int.MaxValue:N0}.");
Console.WriteLine($"Typ double zajmuje {sizeof(double)} bajtów i może przechowywać liczby z zakresu od { double.MinValue:N0} do { double.MaxValue:N0}.");
Console.WriteLine($"Typ decimal zajmuje {sizeof(decimal)} bajtów i może przechowywać liczby z zakresu od { decimal.MinValue:N0} do { decimal.MaxValue:N0}.");

//---------------------------------------
Console.WriteLine("Używanie liczb typu double:");
double a = 0.1;
double b = 0.2;

if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} jest równe 0,3");
}
else
{
    Console.WriteLine($"{a} + {b} NIE jest równe 0,3");
}

// --------------------------------------------
Console.WriteLine("Używanie liczb typu decimal:");

decimal c = 0.1M; // M oznacza literał wartości dziesiętnej
decimal d = 0.2M;

if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} jest równe 0.3");
}
else
{
    Console.WriteLine($"{c} + {d} NIE jest równe 0.3");
}
