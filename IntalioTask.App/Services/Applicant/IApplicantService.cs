namespace IntalioTask.App.Services.Applicant
{
    public interface IApplicantService
    {
        Task<IActionResult> Add(Application data);
    }
}
