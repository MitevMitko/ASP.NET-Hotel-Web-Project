namespace WebProject.Infrastructure.Data.Models.Room
{
    using System.ComponentModel.DataAnnotations;

    using static Common.DataConstants.DataConstants.RoomType;

    public class RoomType
    {
        public RoomType()
        {
            Id = Guid.NewGuid();
            Rooms = new HashSet<Room>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        public ICollection<Room> Rooms { get; set; } = null!;
    }
}
