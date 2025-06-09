using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class Kategorie
{
    public string KategoriaId { get; set; } = null!;

    public string? Opis { get; set; }

    public virtual ICollection<Uprawnienium> Uprawnienia { get; set; } = new List<Uprawnienium>();
}
