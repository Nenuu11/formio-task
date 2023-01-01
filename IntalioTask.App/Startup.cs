namespace IntalioTask.App
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            #region DbContext
            var connectionString = Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(
                    connectionString,
                    b => b.MigrationsAssembly("IntalioTask.DBL")));

            #endregion

            #region InjectedServices
            services.AddScoped<UnitOfWork>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IDegreeService, DegreeService>();
            services.AddScoped<IApplicantService, ApplicantService>();
            #endregion

            services.AddControllers().AddDataAnnotationsLocalization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            app.UseCors(
                x => x.AllowAnyOrigin()
                .AllowAnyMethod().
                AllowAnyHeader()
            );

            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}
