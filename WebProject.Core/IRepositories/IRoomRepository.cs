namespace WebProject.Core.IRepositories
{
    using Infrastructure.Data.Models.Room;
    using WebProject.Infrastructure.Data.Models.ApplicationUser;
    using WebProject.Infrastructure.Data.Models.MappingTables;

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

        Task<IEnumerable<ApplicationUserRoom>> GetUserBookedRoomsAsync(Guid userId);

        Task<IEnumerable<RoomImage>> GetRoomImagesAsync(Guid roomId);

        Task<Room> GetUserBookedRoomsTypesAndBedTypes(Guid id);
    }
}
