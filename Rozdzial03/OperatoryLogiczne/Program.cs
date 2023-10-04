bool a = true;
bool b = false;

WriteLine($"AND  | a     | b    ");
WriteLine($"a    | {a & a,-5} | {a & b,-5} ");
WriteLine($"b    | {b & a,-5} | {b & b,-5} ");
WriteLine();
WriteLine($"OR   | a     | b    ");
WriteLine($"a    | {a | a,-5} | {a | b,-5} ");
WriteLine($"b    | {b | a,-5} | {b | b,-5} ");
WriteLine();
WriteLine($"XOR  | a     | b    ");
WriteLine($"a    | {a ^ a,-5} | {a ^ b,-5} ");
WriteLine($"b    | {b ^ a,-5} | {b ^ b,-5} ");

WriteLine();
WriteLine($"a && ZrobCos() = {a && ZrobCos()}");
WriteLine($"b && ZrobCos() = {b && ZrobCos()}");

private static bool ZrobCos()
{
  WriteLine("Wykonuję ciężką pracę.");
  return true;
}

