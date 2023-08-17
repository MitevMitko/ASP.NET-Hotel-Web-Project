namespace WebProject.Infrastructure.Configurations.ServiceRoom
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.ServiceRoom;

    public class RoomServiceImageEntityConfiguration : IEntityTypeConfiguration<RoomServiceImage>
    {
        public void Configure(EntityTypeBuilder<RoomServiceImage> builder)
        {
            builder
                .HasOne(di => di.RoomService)
                .WithMany(d => d.RoomServiceImages)
                .HasForeignKey(di => di.RoomServiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
