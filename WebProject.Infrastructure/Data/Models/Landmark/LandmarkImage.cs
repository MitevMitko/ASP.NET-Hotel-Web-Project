namespace WebProject.Infrastructure.Data.Models.Landmark
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.DataConstants.DataConstants.Image;

    public class LandmarkImage
    {
        public LandmarkImage()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [Range(ImageMinValue, ImageMaxValue)]
        public byte[] Image { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        [ForeignKey(nameof(Landmark))]
        public Guid LandmarkId { get; set; }
        public Landmark Landmark { get; set; } = null!;
    }
}
