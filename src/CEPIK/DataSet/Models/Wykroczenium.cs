using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class Wykroczenium
{
    public int WykroczenieId { get; set; }

    public string? Opis { get; set; }

    public int OsobaId { get; set; }

    public string? NumerRejestracyjny { get; set; }

    public decimal? Mandat { get; set; }

    public short? PunktyKarne { get; set; }

    public string? Status { get; set; }

    public DateOnly DataWykroczenia { get; set; }

    public virtual Pojazdy? NumerRejestracyjnyNavigation { get; set; }

    public virtual Osoby Osoba { get; set; } = null!;
}
