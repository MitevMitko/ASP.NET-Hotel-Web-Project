namespace WebProject.Infrastructure.Data.Models.Room
{
    using System.ComponentModel.DataAnnotations;

    using static Common.DataConstants.DataConstants.Bed;

    public class Bed
    {

        public Bed()
        {
            Id = Guid.NewGuid();
            Rooms = new HashSet<Room>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TypeMaxLength)]
        public string TypeName { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        public ICollection<Room> Rooms { get; set; } = null!;
    }
}
