namespace WebProject.Infrastructure.Configurations.Room
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.Room;

    public class RoomFacilityEntityConfiguration : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.HasData(SeedFacilities());
        }

        private List<Facility> SeedFacilities()
        {
            List<Facility> facilities = new List<Facility>();

            Facility facility = new Facility()
            {
                Id = 1,
                Title = "TV"
            };

            facilities.Add(facility);

            facility = new Facility()
            {
                Id = 2,
                Title = "Non-smoking room"
            };

            facilities.Add(facility);

            facility = new Facility()
            {
                Id = 3,
                Title = "Smoking room"
            };

            facilities.Add(facility);

            return facilities;
        }
    }
}
