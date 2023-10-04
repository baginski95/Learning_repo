class Zwierze // To jest klasa bazowa dla wszystkich zwierząt
{
  public string? Imie;
  public DateTime DataUrodzenia;
  public byte Nogi;
}

class Kot : Zwierze // To jest klasa wywiedziona z klasy Zwierze
{
  public bool JestUdomowione;
}

class Pajak : Zwierze // Kolejna klasa wywiedziona z klasy Zwierze
{
  public bool JestJadowite;
}
