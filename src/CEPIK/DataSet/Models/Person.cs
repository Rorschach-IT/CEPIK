namespace DataSet.Models;

public partial class Person
{
    public long Pesel { get; set; }

    public string Imię { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string Status { get; set; } = null!;

    public short? IlośćPunktówKarnych { get; set; }

    public string? NumerTelefonu { get; set; }

    public string? Email { get; set; }
}
