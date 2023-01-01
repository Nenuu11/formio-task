namespace IntalioTask.DAL.DBManagers
{
    public class DegreeManager : Repository<Degree>
    {
        public DegreeManager(DbContext ctx) : base(ctx)
        {

        }
    }
}
