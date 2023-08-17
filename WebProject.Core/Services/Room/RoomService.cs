namespace WebProject.Core.Services.Room
{
    using Core.IConfiguration;
    using IServices;
    using Infrastructure.Data.Models.Room;
    using Infrastructure.Data.Models.MappingTables;
    using Models.Landmark;
    using Models.Room;
    using Models.Room.Auxiliary;
    using Models.Room.Enums;
    using Views.Room.Auxiliary;
    using Services.Room.Auxiliary;

    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork unitOfWork;

        public RoomService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public async Task<AddRoomViewModel> AddRoomHttpGet()
        {
            List<CheckboxOption> facilitiesCheckboxes = new List<CheckboxOption>();

            var facilities = await unitOfWork.Rooms.GetAllFacilitiesAsync();

            foreach (var facility in facilities)
            {
                CheckboxOption checkboxOption = new CheckboxOption()
                {
                    IsChecked = false,
                    Description = facility.Title,
                    Value = facility.Id.ToString()
                };

                facilitiesCheckboxes.Add(checkboxOption);
            }

            var model = new AddRoomViewModel()
            {
                Beds = await unitOfWork.Rooms.GetAllBedTypesAsync(),
                RoomTypes = await unitOfWork.Rooms.GetAllRoomTypesAsync(),
                Checkboxes = facilitiesCheckboxes
            };

            return model;
        }

        public async Task AddRoomHttpPost(AddRoomViewModel model)
        {
            Room room = new Room()
            {
                Name = model.Name,
                Description = model.Description,
                PricePerNigth = model.PricePerNight,
                IsDeleted = false,
                BedId = model.BedId,
                RoomTypeId = model.RoomTypeId,
                RoomAvailabilityId = await unitOfWork.Rooms.GetAvailabilityIdRoomStatusAsync("Available")
            };

            await unitOfWork.Rooms.AddAsync(room);

            await unitOfWork.CompleteAsync();

            var roomFacilities = await unitOfWork.Rooms.GetRoomFacilitesAsync(room.Id);

            if (roomFacilities != null)
            {
                foreach (var facilityId in model.UniqueName)
                {
                    RoomFacility roomFacility = new RoomFacility()
                    {
                        RoomId = room.Id,
                        FacilityId = int.Parse(facilityId)
                    };

                    roomFacilities.RoomsFacilities.Add(roomFacility);
                }
            }

            var roomImages = await unitOfWork.RoomImages.AllAsync();

            foreach (var file in model.Files)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    await file.CopyToAsync(ms);

                    byte[] data = ms.ToArray();

                    RoomImage roomImage = new RoomImage()
                    {
                        Image = data,
                        IsDeleted = false,
                        RoomId = room.Id
                    };

                    await unitOfWork.RoomImages.AddAsync(roomImage);
                }
            }

            await unitOfWork.CompleteAsync();
        }

        public async Task<AllRoomsFilteredAndPagedServiceModel> AllRoomsFilteredAndPaged(AllRoomsQueryModel queryModel)
        {
            IQueryable<Room> roomsQuery = unitOfWork.Rooms.GetAllRoomsAndRoomTypes();

            if (!string.IsNullOrWhiteSpace(queryModel.Type))
            {
                roomsQuery = roomsQuery.Where(r => r.RoomType.Name == queryModel.Type);
            }

            if (!string.IsNullOrWhiteSpace(queryModel.BedType))
            {
                roomsQuery = roomsQuery.Where(r => r.Bed.TypeName == queryModel.BedType);
            }

            roomsQuery = queryModel.RoomSorting switch
            {
                RoomSorting.All => roomsQuery,
                RoomSorting.PriceAscending => roomsQuery.OrderBy(r => r.PricePerNigth),
                RoomSorting.PriceDescending => roomsQuery.OrderByDescending(r => r.PricePerNigth)
            };

            var allRooms = roomsQuery.ToList();

            List<AllRoomsViewModel> allRoomsViewModels = new List<AllRoomsViewModel>();

            foreach (var room in allRooms)
            {
                AllRoomsViewModel model = new AllRoomsViewModel()
                {
                    Id = room.Id,
                    Name = room.Name,
                    PricePerNight = room.PricePerNigth,
                    RoomImage = await GetRoomFirstImage(room.Id),
                    FromDate = room.FromDate,
                    ToDate = room.ToDate
                };

                allRoomsViewModels.Add(model);
            }

            return new AllRoomsFilteredAndPagedServiceModel()
            {
                Rooms = allRoomsViewModels
            };
        }

        public async Task<BookRoomViewModel> BookRoomHttpGet(Guid id)
        {
            var entity = await unitOfWork.Rooms.GetByGuidIdAsync(id);

            if (entity != null)
            {
                var model = new BookRoomViewModel()
                {
                    Id = entity.Id,
                    Name = entity.Name
                };

                return model;
            }

            return new BookRoomViewModel();
        }

        public async Task BookRoomHttpPost(BookRoomViewModel model, string userId)
        {
            if (userId == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            var entity = await unitOfWork.Rooms.GetRoomAndApplicationUsersRoomsAsync(model.Id);

            if (entity == null)
            {
                throw new ArgumentException("Invalid room ID");
            }

            if (entity.FromDate == null && entity.ToDate == null)
            {
                entity.FromDate = model.BookFrom;
                entity.ToDate = model.BookFrom.AddDays(model.DaysOfStay);
                entity.ApplicationUsersRooms.Add(new ApplicationUserRoom()
                {
                    UserId = Guid.Parse(userId),
                    RoomId = model.Id
                });

                await unitOfWork.CompleteAsync();
            }
        }

        public async Task<EditRoomViewModel> EditRoomHttpGet(Guid roomId)
        {
            List<CheckboxOption> facilitiesCheckboxes = new List<CheckboxOption>();

            Room roomDetails = await unitOfWork.Rooms.RoomDetailsAsync(roomId);

            var facilities = await unitOfWork.Rooms.GetAllFacilitiesAsync();

            foreach (var facility in facilities)
            {
                CheckboxOption checkboxOption = new CheckboxOption()
                {
                    IsChecked = roomDetails.RoomsFacilities.Any(rf => rf.FacilityId == facility.Id),
                    Description = facility.Title,
                    Value = facility.Id.ToString()
                };

                facilitiesCheckboxes.Add(checkboxOption);
            }

            var model = new EditRoomViewModel()
            {
                Name = roomDetails.Name,
                Description = roomDetails.Description,
                PricePerNight = roomDetails.PricePerNigth,
                BedId = roomDetails.BedId,
                RoomTypeId = roomDetails.RoomTypeId,
                Beds = await unitOfWork.Rooms.GetAllBedTypesAsync(),
                RoomTypes = await unitOfWork.Rooms.GetAllRoomTypesAsync(),
                Checkboxes = facilitiesCheckboxes
            };

            return model;
        }

        public async Task EditRoomHttpPost(EditRoomViewModel model)
        {
            Room roomToEdit = await unitOfWork.Rooms.RoomDetailsAsync(model.Id);

            roomToEdit.Name = model.Name;
            roomToEdit.Description = model.Description;
            roomToEdit.PricePerNigth = model.PricePerNight;
            roomToEdit.BedId = model.BedId;
            roomToEdit.RoomTypeId = model.RoomTypeId;

            var roomFacilities = await unitOfWork.Rooms.GetRoomFacilitesAsync(model.Id);

            if (roomFacilities != null)
            {
                roomFacilities.RoomsFacilities.Clear();

                foreach (string facilityId in model.UniqueName)
                {
                    RoomFacility roomFacility = new RoomFacility()
                    {
                        RoomId = model.Id,
                        FacilityId = int.Parse(facilityId)
                    };

                    roomFacilities.RoomsFacilities.Add(roomFacility);
                }
            }

            var roomImages = await unitOfWork.RoomImages.AllAsync();

            if (model.Files != null)
            {
                foreach (var file in model.Files)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        await file.CopyToAsync(ms);

                        byte[] data = ms.ToArray();

                        RoomImage roomImage = new RoomImage()
                        {
                            Image = data,
                            IsDeleted = false,
                            RoomId = model.Id
                        };

                        await unitOfWork.RoomImages.AddAsync(roomImage);
                    }
                }
            }

            await unitOfWork.CompleteAsync();
        }

        public async Task<DetailsRoomViewModel> RoomDetails(Guid id)
        {
            var roomDetails = await unitOfWork.Rooms.RoomDetailsAsync(id);

            if (roomDetails != null)
            {
                var roomImages = await unitOfWork.RoomImages.GetAllRoomImagesAsync(roomDetails.Id);

                string firstRoomImage = string.Empty;

                List<string> images = new List<string>();

                if (roomImages.Any())
                {
                    byte[] imageData = roomImages.Select(ri => ri.Image).First();

                    firstRoomImage = Convert.ToBase64String(imageData);

                    roomImages.ToList().ForEach(ri => images.Add(Convert.ToBase64String(ri.Image)));
                }

                var model = new DetailsRoomViewModel()
                {
                    Id = roomDetails.Id,
                    Name = roomDetails.Name,
                    Description = roomDetails.Description,
                    PricePerNight = roomDetails.PricePerNigth,
                    BedType = roomDetails.Bed.TypeName,
                    RoomType = roomDetails.RoomType.Name,
                    RoomImage = firstRoomImage,
                    RoomFacilities = roomDetails.RoomsFacilities.Select(rf => rf.Facility).ToList(),
                    RoomImages = images,
                    FromDate = roomDetails.FromDate,
                    ToDate = roomDetails.ToDate
                };

                return model;
            }

            return new DetailsRoomViewModel();
        }

        private async Task<string> GetRoomFirstImage(Guid roomId)
        {
            string firstRoomImage = string.Empty;

            byte[] roomImage = await unitOfWork.RoomImages.GetFirstRoomImageAsync(roomId);

            if (roomImage != null)
            {
                firstRoomImage = Convert.ToBase64String(roomImage);
            }

            return firstRoomImage;
        }
    }
}
