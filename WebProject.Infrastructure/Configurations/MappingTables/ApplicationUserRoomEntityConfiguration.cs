namespace WebProject.Infrastructure.Configurations.MappingTables
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.MappingTables;

    public class ApplicationUserRoomEntityConfiguration : IEntityTypeConfiguration<ApplicationUserRoom>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRoom> builder)
        {
            builder.HasKey(x => new { x.UserId, x.RoomId });
        }
    }
}
