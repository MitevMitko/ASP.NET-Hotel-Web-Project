namespace WebProject.Infrastructure.Data.Models.ServiceRoom
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.DataConstants.DataConstants.Image;

    public class RoomServiceImage
    {
        public RoomServiceImage()
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
        [ForeignKey(nameof(RoomService))]
        public Guid RoomServiceId { get; set; }
        public RoomService RoomService { get; set; } = null!;
    }
}
