namespace WebProject.Infrastructure.Data.Models.ServiceRoom
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using MappingTables;

    using static Common.DataConstants.DataConstants.RoomService;

    public class RoomService
    {
        public RoomService()
        {
            Id = Guid.NewGuid();
            RoomServiceImages = new HashSet<RoomServiceImage>();
            ApplicationUsersRoomServices = new HashSet<ApplicationUserRoomService>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public decimal Weight { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        [ForeignKey(nameof(RoomServiceCategory))]
        public int RoomServiceCategoryId { get; set; }
        public RoomServiceCategory RoomServiceCategory { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(RoomServiceSubCategory))]
        public int RoomServiceSubCategoryId { get; set; }
        public RoomServiceSubCategory RoomServiceSubCategory { get; set; } = null!;

        public ICollection<RoomServiceImage> RoomServiceImages { get; set; } = null!;

        public ICollection<ApplicationUserRoomService> ApplicationUsersRoomServices { get; set; } = null!;
    }
}
