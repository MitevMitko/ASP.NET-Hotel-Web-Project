using WebProject.Core.Models.Room;

namespace WebProject.Core.Services.Room.Auxiliary
{
    public class AllRoomsFilteredAndPagedServiceModel
    {
        public AllRoomsFilteredAndPagedServiceModel()
        {
            Rooms = new HashSet<AllRoomsViewModel>();
        }

        public IEnumerable<AllRoomsViewModel> Rooms { get; set; } = null!;
    }
}
