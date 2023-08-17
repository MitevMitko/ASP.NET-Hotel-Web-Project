namespace WebProject.Infrastructure.Data.Models.MappingTables
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using ApplicationUser;
    using ServiceRoom;

    public class ApplicationUserRoomService
    {
        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(RoomService))]
        public Guid RoomServiceId { get; set; }
        public RoomService RoomService { get; set; } = null!;
    }
}
