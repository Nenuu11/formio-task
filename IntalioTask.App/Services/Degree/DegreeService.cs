namespace IntalioTask.App.Services.Degree
{
    public class DegreeService : IDegreeService
    {
        private readonly UnitOfWork _unitOfWork;
        public DegreeService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> GetList()
        {
            var degrees = await _unitOfWork.DegreeManager.GetAllBindAsync();
            return new JsonResult(degrees); 
        }
    }
}
