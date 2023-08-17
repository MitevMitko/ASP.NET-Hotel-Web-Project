namespace WebProject.Infrastructure.Configurations.MappingTables
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.MappingTables;

    public class ApplicationUserLandmarkEntityConfiguration : IEntityTypeConfiguration<ApplicationUserLandmark>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserLandmark> builder)
        {
            builder.HasKey(x => new { x.UserId, x.LandmarkId });
        }
    }
}
