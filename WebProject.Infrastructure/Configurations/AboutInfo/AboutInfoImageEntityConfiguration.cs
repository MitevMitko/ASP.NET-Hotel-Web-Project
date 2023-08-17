namespace WebProject.Infrastructure.Configurations.AboutInfo
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using WebProject.Infrastructure.Data.Models.AboutInfo;

    public class AboutInfoImageEntityConfiguration : IEntityTypeConfiguration<AboutInfoImage>
    {
        public void Configure(EntityTypeBuilder<AboutInfoImage> builder)
        {
            builder
                .HasOne(aii => aii.AboutInfo)
                .WithMany(ai => ai.AboutInfoImages)
                .HasForeignKey(aii => aii.AboutInfoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
