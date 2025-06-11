namespace DataSet.Models
{
    public partial class Vehicles
    {
        public string numer_rejestracyjny { get; set; } = null!;

        public string VIN { get; set; } = null!;

        public string marka { get; set; } = null!;

        public string model { get; set; } = null!;

        public string rodzaj { get; set; } = null!;

        public short rok_produkcji { get; set; }

        public string dane_silnika { get; set; } = null!;

        public string rodzaj_paliwa { get; set; } = null!;

        public byte liczba_miejsc { get; set; }

        public string kolor { get; set; } = null!;

        public string termin_przeglądu { get; set; }

        public string status_rejestracji { get; set; } = null!;
    }
}
