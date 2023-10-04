int a = 3;
int b = a++;
WriteLine($"a ma wartość {a}, b ma wartość {b}");

int c = 3;
int d = ++c; // inkrementacja zmiennej c wykonana przed przypisaniem
WriteLine($"c ma wartość {c}, d ma wartość {d}");

int e = 11;
int f = 3;
WriteLine($"e ma wartość {e}, f ma wartość {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g ma wartość {g:N1}, f ma wartość {f}");
WriteLine($"g / f = {g / f}");
