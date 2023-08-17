namespace WebProject.Core.Configuration
{
    using Microsoft.Extensions.Logging;

    using System.Threading.Tasks;

    using IConfiguration;
    using IRepositories;
    using Repositories;
    using Infrastucture.Data;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public IRoomRepository Rooms { get; private set; }

        public IRoomImageRepository RoomImages { get; private set; }

        public IContactRepository Contacts { get; private set; }

        public ILandmarkRepository Landmarks { get; private set; }

        public UnitOfWork(
            ApplicationDbContext context)
        {
            _context = context;
            Rooms = new RoomRepository(_context);
            RoomImages = new RoomImageRepository(_context);
            Contacts = new ContactRepository(_context);
            Landmarks = new LandmarkRepository(_context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
