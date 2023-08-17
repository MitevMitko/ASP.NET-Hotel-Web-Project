namespace WebProject.Infrastructure.Data.Models.ServiceRoom
{
    using System.ComponentModel.DataAnnotations;

    using static Common.DataConstants.DataConstants.RoomServiceCategory;

    public class RoomServiceCategory
    {
        public RoomServiceCategory()
        {
            RoomServices = new HashSet<RoomService>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        public ICollection<RoomService> RoomServices { get; set; } = null!;
    }
}
