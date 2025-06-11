namespace DataSet.Models;

public partial class Pojazdy
{
    public string NumerRejestracyjny { get; set; } = null!;

    public string Vin { get; set; } = null!;

    public string Marka { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Rodzaj { get; set; } = null!;

    public short RokProdukcji { get; set; }

    public string DaneSilnika { get; set; } = null!;

    public string RodzajPaliwa { get; set; } = null!;

    public short LiczbaMiejsc { get; set; }

    public string Kolor { get; set; } = null!;

    public DateOnly? TerminPrzeglądu { get; set; }

    public string StatusRejestracji { get; set; } = null!;

    public virtual ICollection<PrzypisaniaUbezpieczenium> PrzypisaniaUbezpieczenia { get; set; } = new List<PrzypisaniaUbezpieczenium>();

    public virtual ICollection<PrzypisaniaWłaścicieli> PrzypisaniaWłaścicielis { get; set; } = new List<PrzypisaniaWłaścicieli>();

    public virtual ICollection<Wykroczenium> Wykroczenia { get; set; } = new List<Wykroczenium>();

    public virtual ICollection<Zdarzenium> Zdarzenies { get; set; } = new List<Zdarzenium>();
}
