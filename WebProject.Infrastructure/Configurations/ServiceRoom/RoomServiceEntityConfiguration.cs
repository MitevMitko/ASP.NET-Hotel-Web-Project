namespace WebProject.Infrastructure.Configurations.ServiceRoom
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.ServiceRoom;

    public class RoomServiceEntityConfiguration : IEntityTypeConfiguration<RoomService>
    {
        public void Configure(EntityTypeBuilder<RoomService> builder)
        {
            builder.HasData(SeedRoomServices());
        }

        private List<RoomService> SeedRoomServices()
        {
            List<RoomService> roomServices = new List<RoomService>();

            RoomService roomService = new RoomService()
            {
                Id = Guid.Parse("fab36e18-df9d-4161-b2e5-5a9fc71181f6"),
                Name = "Tarator",
                Weight = 400,
                Description = "One of the most delicious bulgarian dish.",
                IsDeleted = false,
                RoomServiceCategoryId = 1,
                RoomServiceSubCategoryId = 3
            };

            roomServices.Add(roomService);

            roomService = new RoomService()
            {
                Id = Guid.Parse("7cc82cd1-b5c6-420d-9cea-d15ba4b09884"),
                Name = "Shopska Salata",
                Weight = 400,
                Description = "One of the most delicious bulgarian salad.",
                IsDeleted = false,
                RoomServiceCategoryId = 1,
                RoomServiceSubCategoryId = 2
            };

            roomServices.Add(roomService);

            roomService = new RoomService()
            {
                Id = Guid.Parse("d0978ca5-e228-45e5-89d2-9e6ad507c464"),
                Name = "Hot Chocolate",
                Weight = 500,
                Description = "Very nice hot drink.",
                IsDeleted = false,
                RoomServiceCategoryId = 2,
                RoomServiceSubCategoryId = 4
            };

            roomServices.Add(roomService);

            roomService = new RoomService()
            {
                Id = Guid.Parse("a4f4a4a5-586e-4c59-8f69-e02105b6048f"),
                Name = "Ice Tea",
                Weight = 500,
                Description = "Very nice cold drink.",
                IsDeleted = false,
                RoomServiceCategoryId = 2,
                RoomServiceSubCategoryId = 5
            };

            return roomServices;
        }
    }
}
