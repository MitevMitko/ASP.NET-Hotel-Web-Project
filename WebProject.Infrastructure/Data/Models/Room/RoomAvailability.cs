namespace WebProject.Infrastructure.Data.Models.Room
{
    using System.ComponentModel.DataAnnotations;

    public class RoomAvailability
    {
        public RoomAvailability()
        {
            Id = Guid.NewGuid();
            Rooms = new HashSet<Room>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Type { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        public ICollection<Room> Rooms { get; set; } = null!;
    }
}
