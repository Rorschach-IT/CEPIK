using System;
using System.Collections.Generic;

namespace DataSet.Models;

public partial class AssigningInsurancesToVehicle
{
    public string NumerRejestracyjny { get; set; } = null!;

    public string NumerPolisy { get; set; } = null!;

    public string Typ { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateOnly DataPoczątku { get; set; }

    public DateOnly? DataKońca { get; set; }

    public string Firma { get; set; } = null!;
}
