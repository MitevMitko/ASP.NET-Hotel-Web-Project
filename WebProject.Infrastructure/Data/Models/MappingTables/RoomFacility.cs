namespace WebProject.Infrastructure.Data.Models.MappingTables
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Room;

    public class RoomFacility
    {
        [Required]
        [ForeignKey(nameof(Room))]
        public Guid RoomId { get; set; }
        public Room Room { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Facility))]
        public int FacilityId { get; set; }
        public Facility Facility { get; set; } = null!;
    }
}
