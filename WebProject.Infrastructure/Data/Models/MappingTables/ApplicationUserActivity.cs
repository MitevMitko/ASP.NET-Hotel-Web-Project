namespace WebProject.Infrastructure.Data.Models.MappingTables
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using ApplicationUser;
    using Activity;

    public class ApplicationUserActivity
    {
        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Activity))]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; } = null!;
    }
}
