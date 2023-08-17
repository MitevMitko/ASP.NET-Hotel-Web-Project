namespace WebProject.Infrastructure.Configurations.ServiceRoom
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.ServiceRoom;

    public class RoomServiceCategoryEntityConfiguration : IEntityTypeConfiguration<RoomServiceCategory>
    {
        public void Configure(EntityTypeBuilder<RoomServiceCategory> builder)
        {
            builder.HasData(SeedRoomServiceCategories());
        }

        private List<RoomServiceCategory> SeedRoomServiceCategories()
        {
            List<RoomServiceCategory> roomServiceCategories = new List<RoomServiceCategory>();

            RoomServiceCategory roomServiceCategory = new RoomServiceCategory()
            {
                Id = 1,
                Name = "Dishes",
                IsDeleted = false
            };

            roomServiceCategories.Add(roomServiceCategory);

            roomServiceCategory = new RoomServiceCategory()
            {
                Id = 2,
                Name = "Beverages",
                IsDeleted = false
            };

            roomServiceCategories.Add(roomServiceCategory);

            return roomServiceCategories;
        }
    }
}
