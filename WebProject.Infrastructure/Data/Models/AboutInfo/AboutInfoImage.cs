namespace WebProject.Infrastructure.Data.Models.AboutInfo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.DataConstants.DataConstants.Image;

    public class AboutInfoImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public byte[] Image { get; set; } = null!;

        [Required]
        [Range(ImageMinValue, ImageMaxValue)]
        public bool IsDeleted { get; set; }

        [Required]
        [ForeignKey(nameof(AboutInfo))]
        public Guid AboutInfoId { get; set; }
        public AboutInfo AboutInfo { get; set; } = null!;
    }
}
