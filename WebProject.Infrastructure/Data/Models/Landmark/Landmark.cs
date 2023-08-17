namespace WebProject.Infrastructure.Data.Models.Landmark
{
    using System.ComponentModel.DataAnnotations;

    using MappingTables;

    using static Common.DataConstants.DataConstants.Landmark;

    public class Landmark
    {
        public Landmark()
        {
            Id = Guid.NewGuid();
            LandmarkImages = new HashSet<LandmarkImage>();
            ApplicationUsersLandmarks = new HashSet<ApplicationUserLandmark>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(DistanceMinValue, DistanceMaxValue)]
        public double Distance { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public ICollection<LandmarkImage> LandmarkImages { get; set; } = null!;

        public ICollection<ApplicationUserLandmark> ApplicationUsersLandmarks { get; set; } = null!;
    }
}
