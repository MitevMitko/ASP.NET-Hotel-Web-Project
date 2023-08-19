namespace WebProject.Core.Services.Room.Auxiliary
{
    using Models.Room;

    public class AllRoomsFilteredAndPagedServiceModel
    {
        public AllRoomsFilteredAndPagedServiceModel()
        {
            Rooms = new HashSet<AllRoomsViewModel>();
        }

        public IEnumerable<AllRoomsViewModel> Rooms { get; set; } = null!;
    }
}
