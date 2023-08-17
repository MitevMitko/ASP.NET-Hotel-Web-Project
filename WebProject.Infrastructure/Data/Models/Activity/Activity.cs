namespace WebProject.Infrastructure.Data.Models.Activity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Data.Models.MappingTables;

    using static Common.DataConstants.DataConstants.Activity;

    public class Activity
    {
        public Activity()
        {
            this.ActivityImages = new HashSet<ActivityImage>();
            this.ApplicationUsersActivities = new HashSet<ApplicationUserActivity>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        public double Duration { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        [ForeignKey(nameof(ActivityCategory))]
        public int ActivityCategoryId { get; set; }
        public ActivityCategory ActivityCategory { get; set; } = null!;

        public ICollection<ActivityImage> ActivityImages { get; set; } = null!;

        public ICollection<ApplicationUserActivity> ApplicationUsersActivities { get; set; } = null!;
    }
}
