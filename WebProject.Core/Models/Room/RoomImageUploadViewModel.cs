namespace WebProject.Core.Models.Room
{
    using Microsoft.AspNetCore.Http;

    public class RoomImageUploadViewModel
    {
        public IFormFileCollection Files { get; set; } = null!;
    }
}
