try
{
  checked
  {
    int x = int.MaxValue - 1;
    WriteLine($"Wartość początkowa: {x}");
    x++;
    WriteLine($"Po inkrementacji: {x}");
    x++;
    WriteLine($"Po inkrementacji: {x}");
    x++;
    WriteLine($"Po inkrementacji: {x}");
  }
}
catch (OverflowException)
{
  WriteLine("Wystąpiło przepełnienie, ale złapałem wyjątek.");
}

unchecked
{
  int y = int.MaxValue + 1;

  WriteLine($"Wartość początkowa: {y}");
  y--;
  WriteLine($"Po dekrementacji: {y}");
  y--;
  WriteLine($"Po dekrementacji: {y}");
}
