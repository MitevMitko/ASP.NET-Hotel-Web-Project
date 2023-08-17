namespace WebProject.Core.Models.Room
{
    using WebProject.Infrastructure.Data.Models.Room;

    public class DetailsRoomViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal PricePerNight { get; set; }

        public string BedType { get; set; } = null!;

        public string RoomType { get; set; } = null!;

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public string? RoomImage { get; set; } = null!;

        public IEnumerable<Facility> RoomFacilities { get; set; } = null!;

        public IEnumerable<string> RoomImages { get; set; } = null!;
    }
}
