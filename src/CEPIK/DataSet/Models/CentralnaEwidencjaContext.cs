using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataSet.Models;

public partial class CentralnaEwidencjaContext : DbContext
{
    public CentralnaEwidencjaContext()
    {
    }

    private readonly IConfiguration _configuration;

    public CentralnaEwidencjaContext(DbContextOptions<CentralnaEwidencjaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AssigningInsurancesToVehicle> AssigningInsurancesToVehicles { get; set; }

    public virtual DbSet<AssigningOwnersToLicence> AssigningOwnersToLicences { get; set; }

    public virtual DbSet<AssigningOwnersToVehicle> AssigningOwnersToVehicles { get; set; }

    public virtual DbSet<Kategorie> Kategories { get; set; }

    public virtual DbSet<OffensesOfPeopleAndVehicle> OffensesOfPeopleAndVehicles { get; set; }

    public virtual DbSet<Osoby> Osobies { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Pojazdy> Pojazdies { get; set; }

    public virtual DbSet<Vehicles> Vehicles { get; set; }

    public virtual DbSet<Polisa> Polisas { get; set; }

    public virtual DbSet<PrzypisaniaUbezpieczenium> PrzypisaniaUbezpieczenia { get; set; }

    public virtual DbSet<PrzypisaniaWłaścicieli> PrzypisaniaWłaścicielis { get; set; }

    public virtual DbSet<Uprawnienium> Uprawnienia { get; set; }

    public virtual DbSet<VehiclesEvent> VehiclesEvents { get; set; }

    public virtual DbSet<Wykroczenium> Wykroczenia { get; set; }

    public virtual DbSet<Zdarzenium> Zdarzenia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<CentralnaEwidencjaContext>()
                .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            }

            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AssigningInsurancesToVehicle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("assigning_insurances_to_vehicles");

            entity.Property(e => e.DataKońca).HasColumnName("data_końca");
            entity.Property(e => e.DataPoczątku).HasColumnName("data_początku");
            entity.Property(e => e.Firma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firma");
            entity.Property(e => e.NumerPolisy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("numer_polisy");
            entity.Property(e => e.NumerRejestracyjny)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numer_rejestracyjny");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Typ)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("typ");
        });

        modelBuilder.Entity<AssigningOwnersToLicence>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("assigning_owners_to_licences");

            entity.Property(e => e.DataWażności).HasColumnName("data_ważności");
            entity.Property(e => e.DataWydania).HasColumnName("data_wydania");
            entity.Property(e => e.Imię)
                .HasMaxLength(100)
                .HasColumnName("imię");
            entity.Property(e => e.KategoriaId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("kategoria_id");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(100)
                .HasColumnName("nazwisko");
            entity.Property(e => e.NumerPrawaJazdy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("numer_prawa_jazdy");
            entity.Property(e => e.OsobaId).HasColumnName("osoba_id");
            entity.Property(e => e.Pesel).HasColumnName("PESEL");
        });

        modelBuilder.Entity<AssigningOwnersToVehicle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("assigning_owners_to_vehicles");

            entity.Property(e => e.Imię)
                .HasMaxLength(100)
                .HasColumnName("imię");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(100)
                .HasColumnName("nazwisko");
            entity.Property(e => e.NumerRejestracyjny)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numer_rejestracyjny");
            entity.Property(e => e.OsobaId).HasColumnName("osoba_id");
            entity.Property(e => e.Pesel).HasColumnName("PESEL");
            entity.Property(e => e.Rola)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("rola");
        });

        modelBuilder.Entity<Kategorie>(entity =>
        {
            entity.HasKey(e => e.KategoriaId).HasName("PK__Kategori__D745C940549FEE46");

            entity.ToTable("Kategorie");

            entity.Property(e => e.KategoriaId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("kategoria_id");
            entity.Property(e => e.Opis)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasColumnName("opis");
        });

        modelBuilder.Entity<OffensesOfPeopleAndVehicle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("offenses_of_people_and_vehicles");

            entity.Property(e => e.DataWykroczenia).HasColumnName("data_wykroczenia");
            entity.Property(e => e.Imię)
                .HasMaxLength(100)
                .HasColumnName("imię");
            entity.Property(e => e.Mandat)
                .HasColumnName("mandat");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(100)
                .HasColumnName("nazwisko");
            entity.Property(e => e.NumerRejestracyjny)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numer_rejestracyjny");
            entity.Property(e => e.Opis)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("opis");
            entity.Property(e => e.Pesel).HasColumnName("PESEL");
            entity.Property(e => e.PunktyKarne).HasColumnName("punkty_karne");
            entity.Property(e => e.Status)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Osoby>(entity =>
        {
            entity.HasKey(e => e.OsobaId).HasName("PK__Osoby__E62FFF36E4246AEC");

            entity.ToTable("Osoby");

            entity.HasIndex(e => e.IlośćPunktówKarnych, "filter_ilosc_punktow_karnych");

            entity.HasIndex(e => e.Nazwisko, "filter_nazwisko");

            entity.HasIndex(e => e.Status, "fiter_status");

            entity.Property(e => e.OsobaId).HasColumnName("osoba_id");
            entity.Property(e => e.Email)
                .HasMaxLength(320)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IlośćPunktówKarnych).HasColumnName("ilość_punktów_karnych");
            entity.Property(e => e.Imię)
                .HasMaxLength(100)
                .HasColumnName("imię");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(100)
                .HasColumnName("nazwisko");
            entity.Property(e => e.NumerTelefonu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("numer_telefonu");
            entity.Property(e => e.Pesel).HasColumnName("PESEL");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasMany(d => d.Zdarzenies).WithMany(p => p.Osobas)
                .UsingEntity<Dictionary<string, object>>(
                    "UdziałyOsóbWZdarzeniu",
                    r => r.HasOne<Zdarzenium>().WithMany()
                        .HasForeignKey("ZdarzenieId")
                        .HasConstraintName("FK__Udziały_o__zdarz__5629CD9C"),
                    l => l.HasOne<Osoby>().WithMany()
                        .HasForeignKey("OsobaId")
                        .HasConstraintName("FK__Udziały_o__osoba__5535A963"),
                    j =>
                    {
                        j.HasKey("OsobaId", "ZdarzenieId").HasName("PK__Udziały___657BA2538FE5ECA6");
                        j.ToTable("Udziały_osób_w_zdarzeniu");
                        j.IndexerProperty<int>("OsobaId").HasColumnName("osoba_id");
                        j.IndexerProperty<int>("ZdarzenieId").HasColumnName("zdarzenie_id");
                    });
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("people");

            entity.Property(e => e.Email)
                .HasMaxLength(320)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IlośćPunktówKarnych).HasColumnName("ilość_punktów_karnych");
            entity.Property(e => e.Imię)
                .HasMaxLength(100)
                .HasColumnName("imię");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(100)
                .HasColumnName("nazwisko");
            entity.Property(e => e.NumerTelefonu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("numer_telefonu");
            entity.Property(e => e.Pesel).HasColumnName("PESEL");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Pojazdy>(entity =>
        {
            entity.HasKey(e => e.NumerRejestracyjny).HasName("PK__Pojazdy__4DD3A4C58E6F3939");

            entity.ToTable("Pojazdy");

            entity.HasIndex(e => e.Vin, "UQ__Pojazdy__C5DF234CB0051427").IsUnique();

            entity.HasIndex(e => e.Marka, "filter_Marka");

            entity.HasIndex(e => e.Model, "filter_Model");

            entity.HasIndex(e => e.RodzajPaliwa, "filter_rodzaj_paliwa");

            entity.HasIndex(e => e.StatusRejestracji, "filter_status_rejestracji");

            entity.Property(e => e.NumerRejestracyjny)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numer_rejestracyjny");
            entity.Property(e => e.DaneSilnika)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dane_silnika");
            entity.Property(e => e.Kolor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kolor");
            entity.Property(e => e.LiczbaMiejsc).HasColumnName("liczba_miejsc");
            entity.Property(e => e.Marka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marka");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.Rodzaj)
                .HasMaxLength(50)
                .HasColumnName("rodzaj");
            entity.Property(e => e.RodzajPaliwa)
                .HasMaxLength(12)
                .HasColumnName("rodzaj_paliwa");
            entity.Property(e => e.RokProdukcji).HasColumnName("rok_produkcji");
            entity.Property(e => e.StatusRejestracji)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("status_rejestracji");
            entity.Property(e => e.TerminPrzeglądu).HasColumnName("termin_przeglądu");
            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("VIN");

            entity.HasMany(d => d.Zdarzenies).WithMany(p => p.NumerRejestracyjnies)
                .UsingEntity<Dictionary<string, object>>(
                    "ZdarzeniaPojazdu",
                    r => r.HasOne<Zdarzenium>().WithMany()
                        .HasForeignKey("ZdarzenieId")
                        .HasConstraintName("FK__Zdarzenia__zdarz__5BE2A6F2"),
                    l => l.HasOne<Pojazdy>().WithMany()
                        .HasForeignKey("NumerRejestracyjny")
                        .HasConstraintName("FK__Zdarzenia__numer__5AEE82B9"),
                    j =>
                    {
                        j.HasKey("NumerRejestracyjny", "ZdarzenieId").HasName("PK__Zdarzeni__CE87F9A05F94F0F7");
                        j.ToTable("Zdarzenia_pojazdu");
                        j.IndexerProperty<string>("NumerRejestracyjny")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .HasColumnName("numer_rejestracyjny");
                        j.IndexerProperty<int>("ZdarzenieId").HasColumnName("zdarzenie_id");
                    });
        });

        modelBuilder.Entity<Vehicles>(entity =>
        {
            entity.HasKey(e => e.numer_rejestracyjny);

            entity.ToTable("vehicles");

            entity.Property(e => e.numer_rejestracyjny)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numer_rejestracyjny");

            entity.Property(e => e.VIN)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("VIN");

            entity.Property(e => e.marka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marka");

            entity.Property(e => e.model)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("model");

            entity.Property(e => e.rodzaj)
                .HasMaxLength(50)
                .IsUnicode(true)
                .HasColumnName("rodzaj");

            entity.Property(e => e.rok_produkcji)
                .HasColumnName("rok_produkcji");

            entity.Property(e => e.dane_silnika)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dane_silnika");

            entity.Property(e => e.rodzaj_paliwa)
                .HasMaxLength(12)
                .IsUnicode(true)
                .HasColumnName("rodzaj_paliwa");

            entity.Property(e => e.liczba_miejsc)
                .HasColumnName("liczba_miejsc");

            entity.Property(e => e.kolor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kolor");

            entity.Property(e => e.termin_przeglądu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("termin_przeglądu");

            entity.Property(e => e.status_rejestracji)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("status_rejestracji");
        });

        modelBuilder.Entity<Polisa>(entity =>
        {
            entity.HasKey(e => e.NumerPolisy).HasName("PK__Polisa__86BE557236EE834D");

            entity.ToTable("Polisa");

            entity.HasIndex(e => e.Firma, "filter_firma");

            entity.Property(e => e.NumerPolisy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("numer_polisy");
            entity.Property(e => e.Firma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firma");
        });

        modelBuilder.Entity<PrzypisaniaUbezpieczenium>(entity =>
        {
            entity.HasKey(e => e.PrzypisanieId).HasName("PK__Przypisa__4B8FECB954F129CE");

            entity.ToTable("Przypisania_ubezpieczenia");

            entity.HasIndex(e => e.Status, "filter_status");

            entity.HasIndex(e => e.Typ, "filter_typ");

            entity.Property(e => e.PrzypisanieId).HasColumnName("przypisanie_id");
            entity.Property(e => e.DataKońca).HasColumnName("data_końca");
            entity.Property(e => e.DataPoczątku).HasColumnName("data_początku");
            entity.Property(e => e.NumerPolisy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("numer_polisy");
            entity.Property(e => e.NumerRejestracyjny)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numer_rejestracyjny");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Typ)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("typ");

            entity.HasOne(d => d.NumerPolisyNavigation).WithMany(p => p.PrzypisaniaUbezpieczenia)
                .HasForeignKey(d => d.NumerPolisy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Przypisan__numer__52593CB8");

            entity.HasOne(d => d.NumerRejestracyjnyNavigation).WithMany(p => p.PrzypisaniaUbezpieczenia)
                .HasForeignKey(d => d.NumerRejestracyjny)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Przypisan__numer__5165187F");
        });

        modelBuilder.Entity<PrzypisaniaWłaścicieli>(entity =>
        {
            entity.HasKey(e => new { e.NumerRejestracyjny, e.OsobaId }).HasName("PK__Przypisa__33B15B36F356B2CF");

            entity.ToTable("Przypisania_właścicieli");

            entity.HasIndex(e => e.Rola, "filter_rola");

            entity.Property(e => e.NumerRejestracyjny)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numer_rejestracyjny");
            entity.Property(e => e.OsobaId).HasColumnName("osoba_id");
            entity.Property(e => e.Rola)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("rola");

            entity.HasOne(d => d.NumerRejestracyjnyNavigation).WithMany(p => p.PrzypisaniaWłaścicielis)
                .HasForeignKey(d => d.NumerRejestracyjny)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Przypisan__numer__534D60F1");

            entity.HasOne(d => d.Osoba).WithMany(p => p.PrzypisaniaWłaścicielis)
                .HasForeignKey(d => d.OsobaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Przypisan__osoba__5441852A");
        });

        modelBuilder.Entity<Uprawnienium>(entity =>
        {
            entity.HasKey(e => e.NumerPrawaJazdy).HasName("PK__Uprawnie__C6314BF1364EF898");

            entity.HasIndex(e => e.KategoriaId, "filter_kategoria_id");

            entity.Property(e => e.NumerPrawaJazdy)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("numer_prawa_jazdy");
            entity.Property(e => e.DataWażności).HasColumnName("data_ważności");
            entity.Property(e => e.DataWydania).HasColumnName("data_wydania");
            entity.Property(e => e.KategoriaId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("kategoria_id");
            entity.Property(e => e.OsobaId).HasColumnName("osoba_id");

            entity.HasOne(d => d.Kategoria).WithMany(p => p.Uprawnienia)
                .HasForeignKey(d => d.KategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Uprawnien__kateg__571DF1D5");

            entity.HasOne(d => d.Osoba).WithMany(p => p.Uprawnienia)
                .HasForeignKey(d => d.OsobaId)
                .HasConstraintName("FK__Uprawnien__osoba__5812160E");
        });

        modelBuilder.Entity<VehiclesEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vehicles_events");

            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Imię)
                .HasMaxLength(100)
                .HasColumnName("imię");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(100)
                .HasColumnName("nazwisko");
            entity.Property(e => e.NumerRejestracyjny)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numer_rejestracyjny");
            entity.Property(e => e.Opis)
                .HasMaxLength(500)
                .HasColumnName("opis");
            entity.Property(e => e.Pesel).HasColumnName("PESEL");
            entity.Property(e => e.Rodzaj)
                .HasMaxLength(100)
                .HasColumnName("rodzaj");
            entity.Property(e => e.ZdarzenieId).HasColumnName("zdarzenie_id");
        });

        modelBuilder.Entity<Wykroczenium>(entity =>
        {
            entity.HasKey(e => e.WykroczenieId).HasName("PK__Wykrocze__29CB5D239BAB8EF5");

            entity.HasIndex(e => e.DataWykroczenia, "filter_data_wykroczenia");

            entity.HasIndex(e => e.Mandat, "filter_mandat");

            entity.HasIndex(e => e.PunktyKarne, "filter_punkty_karne");

            entity.HasIndex(e => e.Status, "filter_status");

            entity.Property(e => e.WykroczenieId).HasColumnName("wykroczenie_id");
            entity.Property(e => e.DataWykroczenia).HasColumnName("data_wykroczenia");
            entity.Property(e => e.Mandat)
                .HasColumnType("money")
                .HasColumnName("mandat");
            entity.Property(e => e.NumerRejestracyjny)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numer_rejestracyjny");
            entity.Property(e => e.Opis)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("opis");
            entity.Property(e => e.OsobaId).HasColumnName("osoba_id");
            entity.Property(e => e.PunktyKarne).HasColumnName("punkty_karne");
            entity.Property(e => e.Status)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("status");

            entity.HasOne(d => d.NumerRejestracyjnyNavigation).WithMany(p => p.Wykroczenia)
                .HasForeignKey(d => d.NumerRejestracyjny)
                .HasConstraintName("FK__Wykroczen__numer__59063A47");

            entity.HasOne(d => d.Osoba).WithMany(p => p.Wykroczenia)
                .HasForeignKey(d => d.OsobaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Wykroczen__osoba__59FA5E80");
        });

        modelBuilder.Entity<Zdarzenium>(entity =>
        {
            entity.HasKey(e => e.ZdarzenieId).HasName("PK__Zdarzeni__3545D659B8F6AC7A");

            entity.HasIndex(e => e.Data, "filter_data");

            entity.HasIndex(e => e.Rodzaj, "filter_rodzaj");

            entity.Property(e => e.ZdarzenieId).HasColumnName("zdarzenie_id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Opis)
                .HasMaxLength(500)
                .HasColumnName("opis");
            entity.Property(e => e.Rodzaj)
                .HasMaxLength(100)
                .HasColumnName("rodzaj");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
