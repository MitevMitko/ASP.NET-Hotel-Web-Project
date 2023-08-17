namespace WebProject.Infrastructure.Data.Models.Activity
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    using static Common.DataConstants.DataConstants.Image;

    public class ActivityImage
    {
        public ActivityImage()
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
        [ForeignKey(nameof(Activity))]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; } = null!;
    }
}
