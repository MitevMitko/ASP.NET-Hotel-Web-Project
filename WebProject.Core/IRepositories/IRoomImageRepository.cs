namespace WebProject.Core.IRepositories
{
    using Infrastructure.Data.Models.Room;

    public interface IRoomImageRepository : IGenericRepository<RoomImage>
    {
        Task<IEnumerable<RoomImage>> GetAllRoomImagesAsync(Guid roomId);

        Task<byte[]> GetFirstRoomImageAsync(Guid roomdId);
    }
}
