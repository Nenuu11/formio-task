using IntalioTask.DBL.Entities;

namespace IntalioTask.App.Services.Applicant
{
    public class ApplicantService : IApplicantService
    {
        private readonly UnitOfWork _unitOfWork;
        public ApplicantService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Add(Application data)
        {
            DateTime BDate = DateTime.ParseExact(data.BirthDate, "dd-MM-yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
            var applicant = new IntalioTask.DBL.Entities.Applicant
            {
                FirstName = data.FirstName,
                LastName = data.LastName,
                PhoneNumber = data.PhoneNumber,
                Email = data.Email,
                BirthDate = BDate,
                GraduationYear = data.GraduationYear,
                DegreeId = data.DegreeId,
                YearsOfExperience = data.YearsOfExperience,
                CityId = data.CityId,
                CoverLetter = data.CoverLetter
            };
            var newApplicant = await _unitOfWork.ApplicantManager.AddAsync(applicant);
            if(newApplicant != null)
            {
                return new JsonResult("Application added");
            }
            else
            {
                return new BadRequestObjectResult("error!");
            }
        }
    }
}
