namespace WebProject.Infrastructure.Configurations.Landmark
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models;
    using WebProject.Infrastructure.Data.Models.Landmark;

    public class LandmarkImageEntityConfiguration : IEntityTypeConfiguration<LandmarkImage>
    {
        public void Configure(EntityTypeBuilder<LandmarkImage> builder)
        {
            builder
                .HasOne(li => li.Landmark)
                .WithMany(l => l.LandmarkImages)
                .HasForeignKey(l => l.LandmarkId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
