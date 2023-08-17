namespace WebProject.Infrastructure.Data.Models.Room
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.DataConstants.DataConstants.Image;

    public class RoomImage
    {
        public RoomImage()
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
        [ForeignKey(nameof(Room))]
        public Guid RoomId { get; set; }
        public Room Room { get; set; } = null!;
    }
}
