namespace WebProject.Infrastructure.Configurations.ServiceRoom
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.ServiceRoom;

    public class RoomServiceSubCategoryEntityConfiguration : IEntityTypeConfiguration<RoomServiceSubCategory>
    {
        public void Configure(EntityTypeBuilder<RoomServiceSubCategory> builder)
        {
            builder.HasData(SeedRoomServiceSubCategories());
        }

        private List<RoomServiceSubCategory> SeedRoomServiceSubCategories()
        {
            List<RoomServiceSubCategory> roomServiceCategories = new List<RoomServiceSubCategory>();

            RoomServiceSubCategory roomServiceCategory = new RoomServiceSubCategory()
            {
                Id = 1,
                Name = "Desert",
                IsDeleted = false
            };

            roomServiceCategories.Add(roomServiceCategory);

            roomServiceCategory = new RoomServiceSubCategory()
            {
                Id = 2,
                Name = "Salad",
                IsDeleted = false
            };

            roomServiceCategories.Add(roomServiceCategory);

            roomServiceCategory = new RoomServiceSubCategory()
            {
                Id = 3,
                Name = "Soup",
                IsDeleted = false
            };

            roomServiceCategories.Add(roomServiceCategory);

            roomServiceCategory = new RoomServiceSubCategory()
            {
                Id = 4,
                Name = "Hot Drinks",
                IsDeleted = false
            };

            roomServiceCategories.Add(roomServiceCategory);

            roomServiceCategory = new RoomServiceSubCategory()
            {
                Id = 5,
                Name = "Cold Drinks",
                IsDeleted = false
            };

            roomServiceCategories.Add(roomServiceCategory);

            return roomServiceCategories;
        }
    }
}
