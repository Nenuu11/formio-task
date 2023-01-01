
namespace IntalioTask.DAL
{
    public class UnitOfWork : IDisposable
    {
        private readonly ApplicationDBContext _ctx;
        public ApplicantManager ApplicantManager { get; set; }
        public DegreeManager DegreeManager { get; set; }
        public CountryManager CountryManager { get; set; }
        public CityManager CityManager { get; set; }
        
        public UnitOfWork(ApplicationDBContext ctx)
        {
            _ctx = ctx;
            ApplicantManager = new ApplicantManager(_ctx);
            DegreeManager = new DegreeManager(_ctx);
            CountryManager = new CountryManager(_ctx);
            CityManager = new CityManager(_ctx);
            
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }

}