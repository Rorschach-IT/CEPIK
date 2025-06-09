using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class Osoby
{
    public int OsobaId { get; set; }

    public long Pesel { get; set; }

    public string Imię { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public int? Status { get; set; }

    public short? IlośćPunktówKarnych { get; set; }

    public string? NumerTelefonu { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<PrzypisaniaWłaścicieli> PrzypisaniaWłaścicielis { get; set; } = new List<PrzypisaniaWłaścicieli>();

    public virtual ICollection<Uprawnienium> Uprawnienia { get; set; } = new List<Uprawnienium>();

    public virtual ICollection<Wykroczenium> Wykroczenia { get; set; } = new List<Wykroczenium>();

    public virtual ICollection<Zdarzenium> Zdarzenies { get; set; } = new List<Zdarzenium>();
}
