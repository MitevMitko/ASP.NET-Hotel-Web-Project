namespace WebProject.Infrastructure.Configurations.MappingTables
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using System;

    using Data.Models.MappingTables;

    public class RoomFacilityEntityConfiguration : IEntityTypeConfiguration<RoomFacility>
    {
        public void Configure(EntityTypeBuilder<RoomFacility> builder)
        {
            builder.HasKey(x => new { x.RoomId, x.FacilityId });

            builder.HasData(SeedRoomsFacilities());
        }

        private List<RoomFacility> SeedRoomsFacilities()
        {
            List<RoomFacility> roomsFacilities = new List<RoomFacility>();

            RoomFacility roomFacility = new RoomFacility()
            {
                RoomId = Guid.Parse("c85bf0f6-0bbc-4eac-8944-115f6bafea9f"),
                FacilityId = 1
            };

            roomsFacilities.Add(roomFacility);

            roomFacility = new RoomFacility()
            {
                RoomId = Guid.Parse("c85bf0f6-0bbc-4eac-8944-115f6bafea9f"),
                FacilityId = 2
            };

            roomsFacilities.Add(roomFacility);

            roomFacility = new RoomFacility()
            {
                RoomId = Guid.Parse("acd6875f-a5ac-41ec-9b48-0d09655e01d9"),
                FacilityId = 1
            };

            roomsFacilities.Add(roomFacility);

            roomFacility = new RoomFacility()
            {
                RoomId = Guid.Parse("acd6875f-a5ac-41ec-9b48-0d09655e01d9"),
                FacilityId = 3
            };

            roomsFacilities.Add(roomFacility);

            return roomsFacilities;
        }
    }
}
