namespace WebProject.Core.IServices
{
    using Models.Room;
    using Models.Room.Auxiliary;
    using Models.Landmark;
    using Services.Room.Auxiliary;

    public interface IRoomService
    {
        Task<AllRoomsFilteredAndPagedServiceModel> AllRoomsFilteredAndPaged(AllRoomsQueryModel queryModel);

        Task<DetailsRoomViewModel> RoomDetails(Guid id);

        Task<AddRoomViewModel> AddRoomHttpGet();

        Task AddRoomHttpPost(AddRoomViewModel model);

        Task<EditRoomViewModel> EditRoomHttpGet(Guid roomId);

        Task EditRoomHttpPost(EditRoomViewModel model);

        Task<BookRoomViewModel> BookRoomHttpGet(Guid id);

        Task BookRoomHttpPost(BookRoomViewModel model, string userId);

        Task<AllUserBookedRoomsFilteredServiceModel> AllUserBookedRoomsFiltered(AllUserBookedRoomsQueryModel queryModel, string userId);
    }
}
