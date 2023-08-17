namespace WebProject.Core.Models.Room
{
    public class AllRoomsViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal PricePerNight { get; set; }

        public string? RoomImage { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }
}
