namespace IntalioTask.DAL.DBManagers
{
    public class CountryManager : Repository<Country>
    {
        public CountryManager(DbContext ctx) : base(ctx)
        {

        }
    }
}
