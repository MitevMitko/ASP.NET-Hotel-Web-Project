namespace WebProject.Core.Models.Landmark
{
    public class BookRoomViewModel
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public DateTime BookFrom { get; set; }

        public int DaysOfStay { get; set; }
    }
}
