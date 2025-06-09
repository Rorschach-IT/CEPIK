using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class PrzypisaniaWłaścicieli
{
    public string NumerRejestracyjny { get; set; } = null!;

    public int OsobaId { get; set; }

    public string Rola { get; set; } = null!;

    public virtual Pojazdy NumerRejestracyjnyNavigation { get; set; } = null!;

    public virtual Osoby Osoba { get; set; } = null!;
}
