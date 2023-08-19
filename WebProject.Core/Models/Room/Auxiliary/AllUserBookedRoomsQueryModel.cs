namespace WebProject.Core.Models.Room.Auxiliary
{
    using Enums;

    public class AllUserBookedRoomsQueryModel
    {
        public AllUserBookedRoomsQueryModel()
        {
            Types = new HashSet<string>();
            BedTypes = new HashSet<string>();
            Rooms = new HashSet<UserBookedRoomsViewModel>();
        }

        public string? Type { get; set; }

        public string? BedType { get; set; }

        public RoomSorting RoomSorting { get; set; }

        public IEnumerable<string> Types { get; set; } = null!;

        public IEnumerable<string> BedTypes { get; set; } = null!;

        public IEnumerable<UserBookedRoomsViewModel> Rooms { get; set; } = null!;
    }
}
