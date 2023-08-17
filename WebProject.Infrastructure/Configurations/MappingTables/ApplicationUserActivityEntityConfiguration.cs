namespace WebProject.Infrastructure.Configurations.MappingTables
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.MappingTables;

    public class ApplicationUserActivityEntityConfiguration : IEntityTypeConfiguration<ApplicationUserActivity>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserActivity> builder)
        {
            builder.HasKey(x => new { x.UserId, x.ActivityId });
        }
    }
}
