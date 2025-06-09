using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class Uprawnienium
{
    public string NumerPrawaJazdy { get; set; } = null!;

    public int OsobaId { get; set; }

    public string KategoriaId { get; set; } = null!;

    public DateOnly DataWydania { get; set; }

    public DateOnly? DataWażności { get; set; }

    public virtual Kategorie Kategoria { get; set; } = null!;

    public virtual Osoby Osoba { get; set; } = null!;
}
