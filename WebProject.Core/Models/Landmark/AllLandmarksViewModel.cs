namespace WebProject.Core.Models.Landmark
{
    public class AllLandmarksViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public double Distance { get; set; }
    }
}
