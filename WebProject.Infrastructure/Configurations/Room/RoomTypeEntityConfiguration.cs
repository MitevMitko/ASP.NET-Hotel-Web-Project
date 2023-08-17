namespace WebProject.Infrastructure.Configurations.Room
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.Room;

    public class RoomTypeEntityConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasData(SeedRoomType());
        }

        private List<RoomType> SeedRoomType()
        {
            List<RoomType> roomtypes = new List<RoomType>();

            RoomType roomType = new RoomType()
            {
                Id = Guid.Parse("30F9C331-274C-4316-918A-0DCADAF7B8D9"),
                Name = "Economy",
                IsDeleted = false
            };

            roomtypes.Add(roomType);

            roomType = new RoomType()
            {
                Id = Guid.Parse("9DF60366-5AD5-42F7-8C3F-BF8E1E5BC01E"),
                Name = "Luxury",
                IsDeleted = false
            };

            roomtypes.Add(roomType);

            return roomtypes;
        }
    }
}
