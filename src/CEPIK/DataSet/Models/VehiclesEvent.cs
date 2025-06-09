using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class VehiclesEvent
{
    public int? ZdarzenieId { get; set; }

    public string NumerRejestracyjny { get; set; } = null!;

    public long Pesel { get; set; }

    public string Imię { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public DateOnly? Data { get; set; }

    public string? Rodzaj { get; set; }

    public string? Opis { get; set; }
}
