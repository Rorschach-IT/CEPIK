using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class AssigningOwnersToLicence
{
    public int OsobaId { get; set; }

    public long Pesel { get; set; }

    public string Imię { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string NumerPrawaJazdy { get; set; } = null!;

    public string KategoriaId { get; set; } = null!;

    public DateOnly DataWydania { get; set; }

    public DateOnly? DataWażności { get; set; }
}
