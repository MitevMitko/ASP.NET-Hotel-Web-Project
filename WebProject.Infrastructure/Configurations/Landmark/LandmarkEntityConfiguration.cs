namespace WebProject.Infrastructure.Configurations.Landmark
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.Landmark;

    public class LandmarkEntityConfiguration : IEntityTypeConfiguration<Landmark>
    {
        public void Configure(EntityTypeBuilder<Landmark> builder)
        {
            builder.HasData(SeedLandmarks());
        }

        private List<Landmark> SeedLandmarks()
        {
            List<Landmark> landmarks = new List<Landmark>();

            Landmark landmark = new Landmark()
            {
                Id = Guid.Parse("4eb9fab4-9b37-4936-88ef-0195998922d5"),
                Name = "Orlova Chuka Cave",
                Description = "One of the most beautiful caves in Bulgaria.",
                Distance = 45,
                IsDeleted = false
            };

            landmarks.Add(landmark);

            return landmarks;
        }
    }
}
