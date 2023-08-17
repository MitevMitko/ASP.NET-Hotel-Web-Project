namespace WebProject.Infrastructure.Configurations.Activity
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.Activity;

    public class ActivityImageEntityConfiguration : IEntityTypeConfiguration<ActivityImage>
    {
        public void Configure(EntityTypeBuilder<ActivityImage> builder)
        {
            builder
                .HasOne(ai => ai.Activity)
                .WithMany(a => a.ActivityImages)
                .HasForeignKey(ai => ai.ActivityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
