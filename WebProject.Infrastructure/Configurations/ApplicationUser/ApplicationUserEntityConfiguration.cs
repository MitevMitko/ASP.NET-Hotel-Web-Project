namespace WebProject.Infrastructure.Configurations
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Data.Models.ApplicationUser;

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            //builder.HasData(SeedUsers());
        }

        //private List<ApplicationUser> SeedUsers()
        //{
        //    var users = new List<ApplicationUser>();
        //    var hasher = new PasswordHasher<ApplicationUser>();

        //    var user = new ApplicationUser()
        //    {
        //        Id = Guid.NewGuid(),
        //        UserName = "user@mail.com",
        //        NormalizedUserName = "USER@MAIL.COM",
        //        Email = "user@mail.com",
        //        NormalizedEmail = "USER@MAIL.COM"
        //    };

        //    user.PasswordHash = hasher.HashPassword(user, "user123");

        //    users.Add(user);

        //    user = new ApplicationUser()
        //    {
        //        Id = Guid.NewGuid(),
        //        UserName = "guest@mail.com",
        //        NormalizedEmail = "GUEST@MAIL.COM",
        //        Email = "guest@mail.com",
        //        NormalizedUserName = "GUEST@MAIL.COM"
        //    };

        //    user.PasswordHash = hasher.HashPassword(user, "guest123");

        //    users.Add(user);

        //    return users;
        //}
    }
}
