namespace WebProject.Core.Services.Room.Auxiliary
{
    using Models.Room;

    public class AllUserBookedRoomsFilteredServiceModel
    {
        public AllUserBookedRoomsFilteredServiceModel()
        {
            Rooms = new List<UserBookedRoomsViewModel>();
        }

        public IEnumerable<UserBookedRoomsViewModel> Rooms { get; set; } = null!;
    }
}
