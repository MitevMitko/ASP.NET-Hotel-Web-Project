using WebProject.Core.IRepositories;

namespace WebProject.Core.IConfiguration
{
    public interface IUnitOfWork
    {
        IRoomRepository Rooms { get; }

        IRoomImageRepository RoomImages { get; }

        IContactRepository Contacts { get; }

        ILandmarkRepository Landmarks { get; }

        Task CompleteAsync();
    }
}
