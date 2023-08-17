namespace WebProject.Infrastructure.Data.Models.Room
{
    using System.ComponentModel.DataAnnotations;

    using MappingTables;

    using static Common.DataConstants.DataConstants.Facilities;

    public class Facility
    {
        public Facility()
        {
            RoomsFacilities = new HashSet<RoomFacility>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        public ICollection<RoomFacility> RoomsFacilities { get; set; } = null!;
    }
}
