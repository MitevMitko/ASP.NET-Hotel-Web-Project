namespace WebProject.Infrastructure.Configurations.Room
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.Room;

    public class RoomAvailabilityEntityConfiguration : IEntityTypeConfiguration<RoomAvailability>
    {
        public void Configure(EntityTypeBuilder<RoomAvailability> builder)
        {
            builder.HasData(SeedRoomAvailabilities());
        }

        private List<RoomAvailability> SeedRoomAvailabilities()
        {
            List<RoomAvailability> roomAvailabilityies = new List<RoomAvailability>();

            RoomAvailability roomAvailability = new RoomAvailability()
            {
                Id = Guid.Parse("91520B6D-25F7-4A66-8650-E5644BC84A13"),
                Type = "Available",
                IsDeleted = false
            };

            roomAvailabilityies.Add(roomAvailability);

            roomAvailability = new RoomAvailability()
            {
                Id = Guid.Parse("181D6778-82EA-423B-B2DA-C58FE3F33CBF"),
                Type = "Booked",
                IsDeleted = false
            };

            roomAvailabilityies.Add(roomAvailability);

            return roomAvailabilityies;
        }
    }
}
