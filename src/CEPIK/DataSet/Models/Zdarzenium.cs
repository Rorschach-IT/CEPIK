using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class Zdarzenium
{
    public int ZdarzenieId { get; set; }

    public string? Opis { get; set; }

    public DateOnly Data { get; set; }

    public string Rodzaj { get; set; } = null!;

    public virtual ICollection<Pojazdy> NumerRejestracyjnies { get; set; } = new List<Pojazdy>();

    public virtual ICollection<Osoby> Osobas { get; set; } = new List<Osoby>();
}
