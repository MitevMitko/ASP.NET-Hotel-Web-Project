namespace WebProject.Core.Repositories
{
    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using IRepositories;
    using Infrastructure.Data.Models.Room;
    using Infrastucture.Data;
    using WebProject.Infrastructure.Data.Models.ApplicationUser;
    using WebProject.Infrastructure.Data.Models.MappingTables;

    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Bed>> GetAllBedTypesAsync()
        {
            return await context.Beds.ToListAsync();
        }

        public async Task<IEnumerable<Facility>> GetAllFacilitiesAsync()
        {
            return await context.Facilities.ToListAsync();
        }

        public IQueryable<Room> GetAllRoomsAndRoomTypes()
        {
            return context.Rooms.Include(r => r.RoomType).AsQueryable();
        }

        public async Task<IEnumerable<RoomType>> GetAllRoomTypesAsync()
        {
            return await context.RoomTypes.ToListAsync();
        }

        public async Task<IEnumerable<string>> GetAllRoomTypesNamesAsync()
        {
            return await context.RoomTypes.Select(rt => rt.Name).ToListAsync();
        }

        public async Task<IEnumerable<string>> GetAllRoomsAndRoomTypesNamesAsync()
        {
            return await context.Rooms
                .Include(r => r.RoomType)
                .Select(r => r.Name)
                .ToArrayAsync();
        }

        public async Task<Room> GetRoomFacilitesAsync(Guid id)
        {
            var entity = await context.Rooms
                .Include(r => r.RoomsFacilities)
                .FirstOrDefaultAsync(r => r.Id == id);

            return entity;
        }

        public async Task<IEnumerable<RoomImage>> GetRoomImagesAsync(Guid roomId)
        {
            return await context.RoomImages
                .Where(ri => ri.RoomId == roomId)
                .ToListAsync();
        }

        public async Task<Room> RoomDetailsAsync(Guid id)
        {
            var entity = await context.Rooms
                .Include(r => r.Bed)
                .Include(r => r.RoomType)
                .Include(r => r.RoomsFacilities)
                .ThenInclude(rf => rf.Facility)
                .FirstOrDefaultAsync(r => r.Id == id);

            return entity;
        }

        public async Task<Room> GetUserBookedRoomsTypesAndBedTypes(Guid id)
        {
            var entity = await context.Rooms
                .Include(r => r.Bed)
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync();

            return entity;
        }

        public async Task<IEnumerable<string>> GetAllBedTypesNamesAsync()
        {
            return await context.Beds.Select(b => b.TypeName).ToListAsync();
        }

        public async Task<Guid> GetAvailabilityIdRoomStatusAsync(string roomAvailability)
        {
            return await context.RoomAvailabilities.Where(ra => ra.Type == roomAvailability).Select(ra => ra.Id).FirstOrDefaultAsync();
        }

        public async Task<Room> GetRoomAndApplicationUsersRoomsAsync(Guid id)
        {
            return await context.Rooms
                .Where(r => r.Id == id)
                .Include(r => r.ApplicationUsersRooms)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ApplicationUserRoom>> GetUserBookedRoomsAsync(Guid userId)
        {
            return await context.ApplicationUserRoom
                .Where(aur => aur.UserId == userId)
                .ToListAsync();
        }
    }
}
