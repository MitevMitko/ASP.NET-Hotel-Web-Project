namespace WebProject.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using System.Security.Claims;

    using Core.IConfiguration;
    using Core.IServices;
    using Core.Models.Landmark;
    using Core.Models.Room;
    using Core.Models.Room.Auxiliary;
    using Core.Services.Room.Auxiliary;

    using static Common.DataConstants.DataConstants.Admin;
    using static Core.NotificationMessages.NotificationMessages;

    [Authorize]
    public class RoomController : Controller
    {
        private readonly IRoomService roomService;

        private readonly IUnitOfWork unitOfWork;

        public RoomController(IRoomService _roomService, IUnitOfWork _unitOfWork)
        {
            roomService = _roomService;
            unitOfWork = _unitOfWork;
        }

        [HttpGet]
        [Authorize(Roles = AdminRoleName)]
        public async Task<IActionResult> Add()
        {
            try
            {
                AddRoomViewModel serviceModel = await roomService.AddRoomHttpGet();

                return View(serviceModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong!");

                return RedirectToAction("All", "Room");
            }
        }

        [HttpPost]
        [Authorize(Roles = AdminRoleName)]
        public async Task<IActionResult> Add(AddRoomViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Add", "Room");
            }

            try
            {
                await roomService.AddRoomHttpPost(model);

                return RedirectToAction("Add", "Room");
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Something went wrong!");

                return RedirectToAction("Add", "Room");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllRoomsQueryModel queryModel)
        {
            try
            {
                AllRoomsFilteredAndPagedServiceModel serviceModel = await roomService.AllRoomsFilteredAndPaged(queryModel);

                queryModel.Rooms = serviceModel.Rooms;
                queryModel.BedTypes = await unitOfWork.Rooms.GetAllBedTypesNamesAsync();
                queryModel.Types = await unitOfWork.Rooms.GetAllRoomTypesNamesAsync();

                return View(queryModel);

            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong!");

                return RedirectToAction("All", "Room");
            }
        }

        [HttpGet]
        [Authorize(Roles = AdminRoleName)]
        public async Task<IActionResult> Edit(Guid id)
        {
            try
            {
                EditRoomViewModel serviceModel = await roomService.EditRoomHttpGet(id);

                return View(serviceModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong!");

                return RedirectToAction("All", "Room");
            }
        }

        [HttpPost]
        [Authorize(Roles = AdminRoleName)]
        public async Task<IActionResult> Edit(EditRoomViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Invalid information is entered!";

                return RedirectToAction("Edit", "Room");
            }

            try
            {
                await roomService.EditRoomHttpPost(model);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong!");

                return RedirectToAction("Add", "Room");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(Guid id)
        {
            try
            {
                DetailsRoomViewModel serviceModel = await roomService.RoomDetails(id);

                return View(serviceModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong!");

                return RedirectToAction("All", "Room");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Book(Guid id)
        {
            try
            {
                BookRoomViewModel serviceModel = await roomService.BookRoomHttpGet(id);

                return View(serviceModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong!");

                return RedirectToAction("All", "Room");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Book(BookRoomViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;

                await roomService.BookRoomHttpPost(model, userId);

                return RedirectToAction("Book", "Room");
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Something went wrong!");

                return RedirectToAction("Book", "Room");
            }
        }

        [HttpGet]
        public async Task<IActionResult> UserBookedRooms([FromQuery] AllUserBookedRoomsQueryModel queryModel)
        {
            try
            {
                string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value;

                AllUserBookedRoomsFilteredServiceModel serviceModel = await roomService.AllUserBookedRoomsFiltered(queryModel, userId);

                queryModel.Rooms = serviceModel.Rooms;
                queryModel.BedTypes = await unitOfWork.Rooms.GetAllBedTypesNamesAsync();
                queryModel.Types = await unitOfWork.Rooms.GetAllRoomTypesNamesAsync();

                return View(queryModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong!");

                return RedirectToAction("All", "Room");
            }
        }

        //private bool IsRoomOccupiedForEnteredBookPeriod(Room room, BookRoomViewModel model)
        //{
        //    bool isOccupied = false;

        //    if (room.FromDate == null && room.ToDate == null)
        //    {
        //        isOccupied = false;

        //        return isOccupied;
        //    }

        //    DateTime reservedStartDate = (DateTime)room.FromDate;
        //    DateTime reservedEndDate = (DateTime)room.ToDate;
        //    DateTime enteredStartDate = model.BookFrom;
        //    DateTime enteredEndDate = model.BookFrom.AddDays(model.DaysOfStay);

        //    int numberOfEnteredDaysOfStay = enteredEndDate.Day - enteredStartDate.Day;

        //    for (int cnt = 0; cnt < numberOfEnteredDaysOfStay; cnt++)
        //    {
        //        DateTime currentDate = enteredStartDate.AddDays(cnt).Date;

        //        if (currentDate == reservedStartDate.Date || currentDate == reservedEndDate.Date)
        //        {
        //            isOccupied = true;

        //            break;
        //        }
        //    }

        //    return isOccupied;
        //}
    }
}
