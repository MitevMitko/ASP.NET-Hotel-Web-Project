namespace WebProject.Infrastructure.Data.Models.AboutInfo
{
    using System.ComponentModel.DataAnnotations;

    using static Common.DataConstants.DataConstants.AboutInfo;

    public class AboutInfo
    {
        public AboutInfo()
        {
            Id = Guid.NewGuid();
            AboutInfoImages = new HashSet<AboutInfoImage>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        public ICollection<AboutInfoImage> AboutInfoImages { get; set; } = null!;
    }
}
