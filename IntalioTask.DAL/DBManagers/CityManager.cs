namespace IntalioTask.DAL.DBManagers
{
    public class CityManager : Repository<City>
    {
        public CityManager(DbContext ctx) : base(ctx)
        {

        }
    }
}
