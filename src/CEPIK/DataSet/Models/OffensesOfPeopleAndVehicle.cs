namespace DataSet.Models;

public partial class OffensesOfPeopleAndVehicle
{
    public string NumerRejestracyjny { get; set; } = null!;

    public long Pesel { get; set; }

    public string Imię { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public DateOnly DataWykroczenia { get; set; }

    public string? Opis { get; set; }

    public string? Mandat { get; set; }

    public short? PunktyKarne { get; set; }

    public string? Status { get; set; }
}
