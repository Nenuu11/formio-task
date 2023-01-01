
namespace IntalioTask.App.Services.Country
{
    public class CountryService : ICountryService
    {
        private readonly UnitOfWork _unitOfWork;
        public CountryService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> GetList()
        {
            var countries = await _unitOfWork.CountryManager.GetAllBindAsync();
            return new JsonResult(countries);
        }
    }
}
