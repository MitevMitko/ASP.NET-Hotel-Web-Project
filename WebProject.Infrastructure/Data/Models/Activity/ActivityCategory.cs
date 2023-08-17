namespace WebProject.Infrastructure.Data.Models.Activity
{
    using System.ComponentModel.DataAnnotations;

    public class ActivityCategory
    {
        public ActivityCategory()
        {
            this.Activities = new HashSet<Activity>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        public ICollection<Activity> Activities { get; set; } = null!;
    }
}
