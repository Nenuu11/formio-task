namespace IntalioTask.App.Services.City
{
    public interface ICityService
    {
        IActionResult GetListByCountry(int CountryId);
        Task<IActionResult> GetList();

    }
}
