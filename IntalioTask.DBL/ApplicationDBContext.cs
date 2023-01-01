using IntalioTask.DBL.Entities.Config;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext()
    {
                    
    }
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
       : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=NEHAL;Database=WorkApplication;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CountryConfig());

        //Seeding Data
        modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, CountryName = "Egypt" },
                new Country { CountryId = 2, CountryName = "USA" },
                new Country { CountryId = 3, CountryName = "KSA" },
                new Country { CountryId = 4, CountryName = "UAE" },
                new Country { CountryId = 5, CountryName = "France" }
            );

        modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, CityName = "Cairo", CountryId = 1 },
                new City { CityId = 2, CityName = "Alex", CountryId = 1 },
                new City { CityId = 3, CityName = "Aswan", CountryId = 1 },
                new City { CityId = 4, CityName = "New York", CountryId = 2 },
                new City { CityId = 5, CityName = "Chicago", CountryId = 2 },
                new City { CityId = 6, CityName = "Philadelphia", CountryId = 2 },
                new City { CityId = 7, CityName = "Riyadh", CountryId = 3 },
                new City { CityId = 8, CityName = "Geddah", CountryId = 3 },
                new City { CityId = 9, CityName = "Makkah", CountryId = 3 },
                new City { CityId = 10, CityName = "Dubai", CountryId = 4 },
                new City { CityId = 11, CityName = "Abu Dhabi", CountryId = 4 },
                new City { CityId = 12, CityName = "Al-ain", CountryId = 4 },
                new City { CityId = 13, CityName = "Paris", CountryId = 5 },
                new City { CityId = 14, CityName = "Nice", CountryId = 5 },
                new City { CityId = 15, CityName = "Saint Malo", CountryId = 5 },
                new City { CityId = 16, CityName = "Luxor", CountryId = 1 },
                new City { CityId = 17, CityName = "Ashareqah", CountryId = 4 },
                new City { CityId = 18, CityName = "Al-Madinah", CountryId = 3 }
            );

        modelBuilder.Entity<Degree>().HasData(
                new Degree { DegreeId = 1, DegreeName = "Bachelor’s Degree" },
                new Degree { DegreeId = 2, DegreeName = "Master’s Degree" },
                new Degree { DegreeId = 3, DegreeName = "Doctoral Degree" },
                new Degree { DegreeId = 4, DegreeName = "Professional Degree" },
                new Degree { DegreeId = 5, DegreeName = "Joint Degree" }
            );

    }

    public virtual DbSet<Applicant> Applicants { get; set; }
    public virtual DbSet<Country>  Countries { get; set; }
    public virtual DbSet<City>  Cities { get; set; }
    public virtual DbSet<Degree>  Degrees { get; set; }

}