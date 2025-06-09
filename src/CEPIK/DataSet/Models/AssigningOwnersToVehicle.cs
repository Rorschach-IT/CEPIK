using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class AssigningOwnersToVehicle
{
    public string NumerRejestracyjny { get; set; } = null!;

    public int OsobaId { get; set; }

    public string Rola { get; set; } = null!;

    public long Pesel { get; set; }

    public string Imię { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;
}
