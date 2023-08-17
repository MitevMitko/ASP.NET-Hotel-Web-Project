namespace WebProject.Infrastructure.Configurations.MappingTables
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.MappingTables;

    public class ApplicationUserRoomServiceEntityConfiguration : IEntityTypeConfiguration<ApplicationUserRoomService>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRoomService> builder)
        {
            builder.HasKey(x => new { x.UserId, x.RoomServiceId });
        }
    }
}
