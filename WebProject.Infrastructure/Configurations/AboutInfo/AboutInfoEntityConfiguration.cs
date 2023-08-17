namespace WebProject.Infrastructure.Configurations.AboutInfo
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.AboutInfo;

    public class AboutInfoEntityConfiguration : IEntityTypeConfiguration<AboutInfo>
    {
        public void Configure(EntityTypeBuilder<AboutInfo> builder)
        {
            builder.HasData(SeedAboutInfo());
        }

        private AboutInfo SeedAboutInfo()
        {
            AboutInfo aboutInfo = new AboutInfo()
            {
                Id = Guid.Parse("07C6DD15-8D67-409A-A281-862DDE264DA5"),
                Description = "Hotel Little Vienna is located in Ruse, Bulgaria.",
                IsDeleted = false
            };

            return aboutInfo;
        }
    }
}
