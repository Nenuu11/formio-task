namespace IntalioTask.DAL.DBManagers
{
    public class ApplicantManager : Repository<Applicant>
    {
        public ApplicantManager(DbContext ctx) : base(ctx)
        {

        }
    }
}
