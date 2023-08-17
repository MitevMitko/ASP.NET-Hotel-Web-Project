namespace WebProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WebProject.Core.IConfiguration;
    using WebProject.Core.Models.Landmark;

    public class LandmarkController : Controller
    {
        private readonly ILogger<LandmarkController> _logger;

        private readonly IUnitOfWork _unitOfWork;

        public LandmarkController(ILogger<LandmarkController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var entities = await _unitOfWork.Landmarks.AllAsync();

            var model = entities.Select(l => new AllLandmarksViewModel()
            {
                Id = l.Id,
                Name = l.Name,
                Distance = l.Distance
            });

            return View(model);
        }
    }
}
