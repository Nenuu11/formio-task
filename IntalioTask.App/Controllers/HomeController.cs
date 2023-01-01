
namespace IntalioTask.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ICityService _cityService;
        private readonly ICountryService _countryService;
        private readonly IApplicantService _applicantService;
        private readonly IDegreeService _degreeService;

        public HomeController(ICityService cityService,
            ICountryService countryService,
            IApplicantService applicantService,
            IDegreeService degreeService)
        {
            _cityService = cityService;
            _countryService = countryService;
            _applicantService = applicantService;
            _degreeService = degreeService;
        }

        public IActionResult index()
        {
            //test
            return new JsonResult(new { name = "Nehal", Message = "Hi" });
        }

        [HttpGet]
        [Route("countries")]
        public async Task<IActionResult> Countries()
        {
            var result = await _countryService.GetList();
            return result;
        }


        //I managed to get list of cities by country id but static id not dynamic from FormIO
        //[HttpGet]
        //[Route("cities")]
        //public async Task<IActionResult> Cities(int CountryId)
        //{
        //    var result = _cityService.GetListByCountry(CountryId);
        //    return result;
        //}

        [HttpGet]
        [Route("cities")]
        public async Task<IActionResult> Cities()
        {
            var result = await _cityService.GetList();
            return result;
        }

        [HttpGet]
        [Route("degrees")]
        public async Task<IActionResult> Degrees()
        {
            var result = await _degreeService.GetList();
            return result;
        }

        [HttpPost]
        [Route("save")]
        public async Task<IActionResult> saveApplicant([FromBody] Application data)
        {
            var result = await _applicantService.Add(data);
            return result;
        }

    }
}