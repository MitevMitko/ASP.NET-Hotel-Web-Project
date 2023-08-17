namespace WebProject.Infrastructure.Data.Models.MappingTables
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using ApplicationUser;
    using Landmark;

    public class ApplicationUserLandmark
    {
        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Landmark))]
        public Guid LandmarkId { get; set; }
        public Landmark Landmark { get; set; } = null!;
    }
}
