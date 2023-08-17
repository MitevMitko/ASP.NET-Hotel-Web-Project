namespace WebProject.Core.IRepositories
{
    using Infrastructure.Data.Models.Room;

    public interface IRoomRepository : IGenericRepository<Room>
    {
        Task<Room> RoomDetailsAsync(Guid id);

        Task<Room> GetRoomFacilitesAsync(Guid id);

        Task<IEnumerable<Facility>> GetAllFacilitiesAsync();

        Task<IEnumerable<Bed>> GetAllBedTypesAsync();

        Task<IEnumerable<RoomType>> GetAllRoomTypesAsync();

        Task<IEnumerable<string>> GetAllRoomsAndRoomTypesNamesAsync();

        Task<IEnumerable<string>> GetAllRoomTypesNamesAsync();

        Task<IEnumerable<string>> GetAllBedTypesNamesAsync();

        IQueryable<Room> GetAllRoomsAndRoomTypes();

        Task<Guid> GetAvailabilityIdRoomStatusAsync(string roomAvailability);

        Task<Room> GetRoomAndApplicationUsersRoomsAsync(Guid id);
    }
}
