namespace WebProject.Infrastructure.Configurations.Activity
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.Activity;

    public class ActivityEntityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder
                .HasOne(a => a.ActivityCategory)
                .WithMany(ac => ac.Activities)
                .HasForeignKey(a => a.ActivityCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(SeedActivities());
        }

        private List<Activity> SeedActivities()
        {
            List<Activity> activities = new List<Activity>();

            Activity activity = new Activity()
            {
                Id = 1,
                Title = "Fitness",
                Duration = 90,
                Price = 10,
                IsDeleted = false,
                ActivityCategoryId = 1
            };

            activities.Add(activity);

            activity = new Activity()
            {
                Id = 2,
                Title = "Horseback Riding",
                Duration = 150,
                Price = 60,
                IsDeleted = false,
                ActivityCategoryId = 2
            };

            activities.Add(activity);

            activity = new Activity()
            {
                Id = 3,
                Title = "Sauna",
                Duration = 120,
                Price = 40,
                IsDeleted = false,
                ActivityCategoryId = 3
            };

            activities.Add(activity);

            return activities;
        }
    }
}
