namespace WebProject.Core.Repositories
{
    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using IRepositories;
    using Infrastucture.Data;
    using Infrastructure.Data.Models.Room;

    public class RoomImageRepository : GenericRepository<RoomImage>, IRoomImageRepository
    {
        public RoomImageRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<RoomImage>> GetAllRoomImagesAsync(Guid roomId)
        {
            return await context.RoomImages.Where(ri => ri.RoomId == roomId).ToListAsync();
        }

        public async Task<byte[]> GetFirstRoomImageAsync(Guid roomId)
        {
            return await context.RoomImages
                .Where(ri => ri.RoomId == roomId)
                .Select(ri => ri.Image)
                .FirstOrDefaultAsync();
        }
    }
}
