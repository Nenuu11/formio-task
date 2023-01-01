using IntalioTask.App.Models.DTO;

namespace IntalioTask.App.Services.City
{
    public class CityService : ICityService
    {
        private readonly UnitOfWork _unitOfWork;
        public CityService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> GetList()
        {
            var cities = await _unitOfWork.CityManager.GetAllBindAsync();
            return new JsonResult(cities);
        }

        public IActionResult GetListByCountry(int CountryId)
        {
            var c = _unitOfWork.CountryManager.GetById(CountryId);

            if (c == null)
            {
                return new BadRequestObjectResult(new { Message = "Country does not exist!" });
            }
            var myCities = _unitOfWork.CityManager.GetAll().Where(c => c.CountryId == CountryId)
                .Select(c =>
                new CityDTO
                {
                    Id = c.CityId,
                    CountryId = c.CountryId,
                    Name = c.CityName,
                    CountryName = c.Country.CountryName
                }).ToList();
            return new JsonResult(myCities);


        }
    }
}
