namespace WebProject.Infrastructure.Data.Models.ApplicationUser
{
    using Microsoft.AspNetCore.Identity;

    using MappingTables;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.ApplicationUsersRooms = new HashSet<ApplicationUserRoom>();
            this.ApplicationUsersLandmarks = new HashSet<ApplicationUserLandmark>();
            this.ApplicationUsersRoomServices = new HashSet<ApplicationUserRoomService>();
            this.ApplicationUsersActivities = new HashSet<ApplicationUserActivity>();
        }

        public ICollection<ApplicationUserRoom> ApplicationUsersRooms { get; set; } = null!;

        public ICollection<ApplicationUserLandmark> ApplicationUsersLandmarks { get; set; } = null!;

        public ICollection<ApplicationUserRoomService> ApplicationUsersRoomServices { get; set; } = null!;

        public ICollection<ApplicationUserActivity> ApplicationUsersActivities { get; set; } = null!;
    }
}
