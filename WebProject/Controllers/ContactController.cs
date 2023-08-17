namespace WebProject.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using WebProject.Core.IConfiguration;
    using WebProject.Core.Models.Contact;

    [Authorize]
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        private readonly IUnitOfWork _unitOfWork;

        public ContactController(ILogger<ContactController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var entities = await _unitOfWork.Contacts.AllAsync();

            var model = entities.Select(c => new AllContactsViewModel()
            {
                Id = c.Id,
                Email = c.Email,
                PhoneNumber = c.Phone
            });

            return View(model);
        }
    }
}
