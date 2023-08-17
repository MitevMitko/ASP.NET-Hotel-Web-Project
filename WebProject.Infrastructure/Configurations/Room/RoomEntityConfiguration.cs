namespace WebProject.Infrastructure.Configurations.Room
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.Room;

    public class RoomEntityConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder
                .HasOne(r => r.Bed)
                .WithMany(b => b.Rooms)
                .HasForeignKey(r => r.BedId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(r => r.RoomType)
                .WithMany(rt => rt.Rooms)
                .HasForeignKey(r => r.RoomTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(r => r.RoomAvailability)
                .WithMany(ra => ra.Rooms)
                .HasForeignKey(r => r.RoomAvailabilityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(SeedRooms());
        }

        private List<Room> SeedRooms()
        {
            List<Room> rooms = new List<Room>();

            Room room = new Room()
            {
                Id = Guid.Parse("c85bf0f6-0bbc-4eac-8944-115f6bafea9f"),
                Name = "Hortensia",
                Description = "Luxury and cozy room on reasonable price per night.",
                PricePerNigth = 250,
                FromDate = null,
                ToDate = null,
                IsDeleted = false,
                BedId = Guid.Parse("6622B98E-2130-4633-B227-23DE72BC0021"),
                RoomTypeId = Guid.Parse("9DF60366-5AD5-42F7-8C3F-BF8E1E5BC01E"),
                RoomAvailabilityId = Guid.Parse("91520B6D-25F7-4A66-8650-E5644BC84A13")
            };

            rooms.Add(room);

            room = new Room()
            {
                Id = Guid.Parse("acd6875f-a5ac-41ec-9b48-0d09655e01d9"),
                Name = "Mustang",
                Description = "Cozy and nice room on reasonable price per night.",
                PricePerNigth = 100,
                FromDate = null,
                ToDate = null,
                IsDeleted = false,
                BedId = Guid.Parse("7A644AEA-E74A-49E2-BAEE-804A178A00B7"),
                RoomTypeId = Guid.Parse("30F9C331-274C-4316-918A-0DCADAF7B8D9"),
                RoomAvailabilityId = Guid.Parse("91520B6D-25F7-4A66-8650-E5644BC84A13")
            };

            rooms.Add(room);

            return rooms;
        }
    }
}
