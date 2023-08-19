namespace WebProject.Infrastucture.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Internal;

    using System.Reflection;

    using Infrastructure.Data.Models.AboutInfo;
    using Infrastructure.Data.Models.ApplicationUser;
    using Infrastructure.Data.Models.Contact;
    using Infrastructure.Data.Models.Landmark;
    using Infrastructure.Data.Models.MappingTables;
    using Infrastructure.Data.Models.Room;
    using Infrastructure.Data.Models.ServiceRoom;
    using Infrastructure.Data.Models.Activity;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<AboutInfo> AboutInfo { get; set; } = null!;

        public DbSet<AboutInfoImage> AboutInfoImages { get; set; } = null!;

        public DbSet<Activity> Activities { get; set; } = null!;

        public DbSet<ActivityCategory> ActivityCategories { get; set; } = null!;

        public DbSet<ActivityImage> ActivityImages { get; set; } = null!;

        public DbSet<ApplicationUserLandmark> ApplicationUsersLandmarks { get; set; } = null!;

        public DbSet<ApplicationUserRoom> ApplicationUserRoom { get; set; } = null!;

        public DbSet<Bed> Beds { get; set; } = null!;

        public DbSet<Contact> Contacts { get; set; } = null!;

        public DbSet<Facility> Facilities { get; set; } = null!;

        public DbSet<Landmark> Landmarks { get; set; } = null!;

        public DbSet<LandmarkImage> LandmarkImages { get; set; } = null!;

        public DbSet<Room> Rooms { get; set;  } = null!;

        public DbSet<RoomAvailability> RoomAvailabilities { get; set; } = null!;

        public DbSet<RoomFacility> RoomsFacilities { get; set; } = null!;

        public DbSet<RoomImage> RoomImages { get; set; } = null!;

        public DbSet<RoomType> RoomTypes { get; set; } = null!;

        public DbSet<RoomService> RoomServices { get; set; } = null!;

        public DbSet<RoomServiceCategory> RoomServiceCategories { get; set; } = null!;

        public DbSet<RoomServiceImage> RoomServiceImages { get; set; } = null!;

        public DbSet<RoomServiceSubCategory> RoomServiceSubCategories { get;  set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(ApplicationDbContext)) ?? Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }

    }
}