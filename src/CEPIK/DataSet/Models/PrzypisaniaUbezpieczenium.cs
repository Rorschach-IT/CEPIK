using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class PrzypisaniaUbezpieczenium
{
    public int PrzypisanieId { get; set; }

    public string NumerRejestracyjny { get; set; } = null!;

    public string NumerPolisy { get; set; } = null!;

    public string Typ { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateOnly DataPoczątku { get; set; }

    public DateOnly? DataKońca { get; set; }

    public virtual Polisa NumerPolisyNavigation { get; set; } = null!;

    public virtual Pojazdy NumerRejestracyjnyNavigation { get; set; } = null!;
}
