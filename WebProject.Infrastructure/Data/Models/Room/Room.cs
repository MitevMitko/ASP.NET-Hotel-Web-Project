namespace WebProject.Infrastructure.Data.Models.Room
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using MappingTables;

    using static Common.DataConstants.DataConstants.Room;

    public class Room
    {
        public Room()
        {
            Id = Guid.NewGuid();
            RoomImages = new HashSet<RoomImage>();
            RoomsFacilities = new HashSet<RoomFacility>();
            ApplicationUsersRooms = new HashSet<ApplicationUserRoom>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public decimal PricePerNigth { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        [ForeignKey(nameof(Bed))]
        public Guid BedId { get; set; }
        public Bed Bed { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(RoomType))]
        public Guid RoomTypeId { get; set; }
        public RoomType RoomType { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(RoomAvailability))]
        public Guid RoomAvailabilityId { get; set; }
        public RoomAvailability RoomAvailability { get; set; } = null!;

        public ICollection<RoomImage> RoomImages { get; set; } = null!;

        public ICollection<RoomFacility> RoomsFacilities { get; set; } = null!;

        public ICollection<ApplicationUserRoom> ApplicationUsersRooms { get; set; } = null!;
    }
}
