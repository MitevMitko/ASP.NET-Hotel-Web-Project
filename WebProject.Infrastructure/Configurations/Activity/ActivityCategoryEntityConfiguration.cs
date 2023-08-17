namespace WebProject.Infrastructure.Configurations.Activity
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.Activity;

    public class ActivityCategoryEntityConfiguration : IEntityTypeConfiguration<ActivityCategory>
    {
        public void Configure(EntityTypeBuilder<ActivityCategory> builder)
        {
            builder.HasData(SeedActivityCategories());
        }

        private List<ActivityCategory> SeedActivityCategories()
        {
            List<ActivityCategory> activityCategories = new List<ActivityCategory>();

            ActivityCategory activityCategory = new ActivityCategory()
            {
                Id = 1,
                Title = "Fitness",
                IsDeleted = false
            };

            activityCategories.Add(activityCategory);

            activityCategory = new ActivityCategory()
            {
                Id = 2,
                Title = "Horseback Riding",
                IsDeleted = false
            };

            activityCategories.Add(activityCategory);

            activityCategory = new ActivityCategory()
            {
                Id = 3,
                Title = "Sauna",
                IsDeleted = false
            };

            activityCategories.Add(activityCategory);

            activityCategory = new ActivityCategory()
            {
                Id = 4,
                Title = "Roupse Course",
                IsDeleted = false
            };

            activityCategories.Add(activityCategory);

            return activityCategories;
        }
    }
}
