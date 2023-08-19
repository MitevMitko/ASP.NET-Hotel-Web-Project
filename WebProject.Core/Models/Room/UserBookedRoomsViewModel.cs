namespace WebProject.Core.Models.Room
{
    public class UserBookedRoomsViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal PricePerNight { get; set; }

        public int DaysOfStay { get; set; }

        public decimal TotalPrice { get; set; }

        public string? RoomImage { get; set; }

        public string RoomType { get; set; } = null!;

        public string BedType { get; set; } = null!;

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }
}
