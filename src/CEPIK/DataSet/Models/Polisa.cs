using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class Polisa
{
    public string NumerPolisy { get; set; } = null!;

    public string Firma { get; set; } = null!;

    public virtual ICollection<PrzypisaniaUbezpieczenium> PrzypisaniaUbezpieczenia { get; set; } = new List<PrzypisaniaUbezpieczenium>();
}
